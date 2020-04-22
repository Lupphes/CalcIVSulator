Name "CalcIVSulator"
Outfile "CalcIVSulator_setup.exe"
InstallDir $TEMP\CalcIVSulator
Section ""
    SetOutPath $TEMP\CalcIVSulator
    File /r .\src\CalculatorGUI\publish\*
    ExecWait $TEMP\CalcIVSulator\setup.exe
SectionEnd