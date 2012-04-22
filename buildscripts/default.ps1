$framework = '4.0'

properties { 
    $scripts_dir = Split-Path $psake.build_script_file
    $build_dir = $scripts_dir | Split-Path
    $build_output = "$build_dir\artifacts\"
    $release_output = "$build_dir\release\bin\"
	$nuget_output = "$build_dir\release\nuget\"
    $code_dir = "$build_dir\src"
	$xunit_lib = "$build_dir\src\packages\xunit.1.9.0.1566\lib\"
    $xunit_runners = "$build_dir\src\packages\xunit.runners.1.9.0.1566\tools\"
	$nuget_tool = "$build_dir\src\.nuget\NuGet.exe"
}

include .\psake_ext.ps1

task default -depends Release, Nuget

task Release -depends Test {
    Write-Host "Creating release..." -ForegroundColor Green

    cp $build_output\System.VarintBitConverter.dll $release_output
}

task Nuget -depends Test {
    Write-Host "Creating nuget package..." -ForegroundColor Green
	
	$lib = "$nuget_output\lib\Net40" 
	mkdir $lib | out-null
    cp $build_output\System.VarintBitConverter.dll $lib
	$version = [System.Diagnostics.FileVersionInfo]::GetVersionInfo("$build_output\System.VarintBitConverter.dll").FileVersion;
    Write-Host "Version: $version"
	Generate-NuSpecFile -file "$nuget_output\VarintBitConverter.nuspec" -version "$version"
	$old = pwd
	cd $nuget_output
	Exec { &"$nuget_tool" pack VarintBitConverter.nuspec }
	cd $old	
}

task Test -depends Compile, Clean { 
    Write-Host "Testing..." -ForegroundColor Green
    
    $old = pwd
    cd $xunit_lib
    cp $xunit_lib\Xunit.dll $build_output
    Exec { &"$xunit_runners\xunit.console.clr4.exe" "$build_output\VarintBitConverter.UnitTests.dll" }
    cd $old	
}

task Compile -depends Clean { 
    Write-Host "Compiling..." -ForegroundColor Green
    
    Exec { msbuild "$code_dir\VarintBitConverter.sln" /t:Build /p:Configuration=Release /v:quiet /p:OutDir=$build_output } 
}

task Clean { 
    Write-Host "Cleaning..." -ForegroundColor Green
  
    if (Test-Path $build_output) 
    {
        rd $build_output -rec -force | out-null
    }
    mkdir $build_output | out-null
    
    if (Test-Path $release_output) 
    {
        rd $release_output -rec -force | out-null
    }
    mkdir $release_output | out-null
    
	if (Test-Path $nuget_output) 
    {
        rd $nuget_output -rec -force | out-null
    }
    mkdir $nuget_output | out-null
	
    Exec { msbuild "$code_dir\VarintBitConverter.sln" /t:Clean /p:Configuration=Release /v:quiet }
}