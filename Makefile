# CalcIVSulator (Simple calculator with GUI and mathematical library)
# Copyright (c) 2020 Viktor Rucky, Ondrej Sloup, Vojtech Vlach

# This file is part of CalcIVSulator.

# CalcIVSulator is free software: you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation, either version 3 of the License, or
# (at your option) any later version.

# CalcIVSulator is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.

# You should have received a copy of the GNU General Public License
# along with CalcIVSulator.  If not, see <https://www.gnu.org/licenses/>.

SHELL=powershell

all: run

pack: clean
	if (test-path .\xrucky01_xsloup02_xvlach22\) {Remove-Item .\xrucky01_xsloup02_xvlach22\ -Recurse}
	mkdir .\xrucky01_xsloup02_xvlach22\repo
	mkdir .\xrucky01_xsloup02_xvlach22\doc
	mkdir .\xrucky01_xsloup02_xvlach22\install
	if (test-path $$env:temp\xrucky01_xsloup02_xvlach22\) {Remove-Item $$env:temp\xrucky01_xsloup02_xvlach22\ -Recurse}
	-robocopy . $$env:temp\xrucky01_xsloup02_xvlach22\ /E
	Move-Item -Path $$env:temp\xrucky01_xsloup02_xvlach22\* -Destination .\xrucky01_xsloup02_xvlach22\repo
	Move-Item -Path .\xrucky01_xsloup02_xvlach22\repo\src\UserDocumentation\Help\ -Destination .\xrucky01_xsloup02_xvlach22\doc
	Move-Item .\xrucky01_xsloup02_xvlach22\repo\CalcIVSulator_setup.exe .\xrucky01_xsloup02_xvlach22\install\CalcIVSulator_setup.exe
	Compress-Archive -Path .\xrucky01_xsloup02_xvlach22\ -DestinationPath .\xrucky01_xsloup02_xvlach22.zip

clean:
	Remove-Item .\doc\*.* -Exclude "dokumentace.tex", "GNU Free Documentation License.tex"
	if (test-path .\src\CalculatorGUI\publish) {Remove-Item .\src\CalculatorGUI\publish -Recurse}

run:
	.\src\CalculatorGUI\bin\Release\CalculatorGUI.exe

profile:
	Get-Content .\src\SampleStandardDeviation\data\data1000.txt | .\src\SampleStandardDeviation\bin\Release\SampleStandardDeviation.exe

help:
	Write-Host "CalcIVSulator Help`r`n0. Je treba mit Visual Studio 2019 (s podporou C# a .NET Framework 2019), LaTeX (s prikazem latexmk) a Nullsoft Scriptable Install System`r`n1. Otervrete solution file (src/IVSSemesterProject.sln) ve Visual Studiu`r`n2. Sestavte cele reseni`r`n3. Prepnete se do projektu CalculatorGUI`r`n4. Publikujte projekt`r`n5. Zkompilujte GenerateFinalSetup.nsi pomoci Nullsoft Scriptable Install System"