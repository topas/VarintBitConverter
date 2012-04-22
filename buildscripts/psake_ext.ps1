
function Generate-NuSpecFile
{
param(
	[string]$version,
	[string]$file = $(throw "file is a required parameter.")
)
  $nuspec = "<?xml version=""1.0""?>
<package>
  <metadata>
    <id>VarintBitConverter</id>
    <version>$version</version>
    <authors>Tomáš Pastorek</authors>
    <licenseUrl>https://github.com/topas/VarintBitConverter/blob/master/LICENSE</licenseUrl>
    <projectUrl>https://github.com/topas/VarintBitConverter</projectUrl>
    <requireLicenseAcceptance>false</requireLicenseAcceptance>
    <description>System.VarintBitConverter is static utility class very similar to BitConverter. It converts numeric .NET types to (and from) varint.</description>
    <summary>System.VarintBitConverter is static utility class very similar to BitConverter. It converts numeric .NET types to (and from) varint.</summary>
    <language>en-US</language>
  </metadata>
</package>
"

	$dir = [System.IO.Path]::GetDirectoryName($file)
	if ([System.IO.Directory]::Exists($dir) -eq $false)
	{
		Write-Host "Creating directory $dir"
		[System.IO.Directory]::CreateDirectory($dir)
	}
	Write-Host "Generating nuspec file: $file"
	Write-Output $nuspec > $file
}