SHELL=powershell

all: ./src/CalculatorGUI/bin/Release/CalculatorGUI.exe
	.\src\CalculatorGUI\bin\Release\CalculatorGUI.exe

clean:
	Remove-Item .\doc\*.* -Exclude "dokumentace.tex", "GNU Free Documentation License.tex"
	Remove-Item .\src\CalculatorGUI\publish

run:
	.\src\CalculatorGUI\bin\Release\CalculatorGUI.exe

profile:
	Get-Content .\src\SampleStandartDeviation\data\data1000.txt | .\src\SampleStandartDeviation\bin\Release\netcoreapp3.1\SampleStandartDeviation.exe