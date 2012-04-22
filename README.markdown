About VarintBitConverter
=============
System.VarintBitConverter is static utility class very similar to BitConverter (http://msdn.microsoft.com/en-us/library/system.bitconverter.aspx).

Varint is 128 base encoding for numbers (https://developers.google.com/protocol-buffers/docs/encoding#varints) used by Protocol Buffers and other projects. 
For signed numbers is using ZigZag encoding.

Usage:
-----------------

* method GetBytes(...) converts .NET type to varint byte array. 
* To...(byte[]) method convert varint byte array to .NET type

Libraries & Tools
-----------------
This project is using: 

* xUnit testing library: http://xunit.codeplex.com/
* Psake build automation tool: https://github.com/JamesKovacs/psake

Requirements
------------
* .NET Framework 4.0
* PowerShell for running Psake

License
-------
Project is released under BSD license.

