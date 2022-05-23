@echo off
@echo ...
@REM Uncomment the following line if you want to keep this BAT file for later use.
@REM copy "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\execAfter.bat" "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\execAfter_bak.bat" > NUL:
@REM If user didn't provide his own vsdocman_overrides.css in external files, copy the default (empty) one.
echo IF NOT EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\vsdocman_overrides.css" copy "C:\Program Files\VSdocman\Templates\vsdocman_overrides.css" "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\vsdocman_overrides.css" > NUL:
IF NOT EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\vsdocman_overrides.css" copy "C:\Program Files\VSdocman\Templates\vsdocman_overrides.css" "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\vsdocman_overrides.css" > NUL:
@echo Creating dynamic TOC...
echo IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\toc--" rmdir "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\toc--" /S /Q > NUL:
IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\toc--" rmdir "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\toc--" /S /Q > NUL:
@"C:\Program Files\VSdocman\Templates\HTML\Util\Helixoft.DynamicTocCreator.exe" /outputDirectory "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\toc--" "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\static_toc.xml"
@IF ERRORLEVEL 1 GOTO dynTocError
echo IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\static_toc.xml" del "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\static_toc.xml" > NUL:
IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\static_toc.xml" del "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\static_toc.xml" > NUL:
@:dynTocError
@echo Creating search index...
@"C:\Program Files\VSdocman\Templates\HTML\Util\HelixoftHtmlIndexer.exe" "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc" "*.htm?" "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\search--" version2
echo IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\msdn2019" rmdir "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\msdn2019" /S /Q > NUL:
IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\msdn2019" rmdir "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\msdn2019" /S /Q > NUL:
echo mkdir "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\msdn2019" > NUL:
mkdir "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\msdn2019" > NUL:
echo copy "C:\Program Files\VSdocman\Templates\msdn2019\*.*" "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\msdn2019\*.*" > NUL:
copy "C:\Program Files\VSdocman\Templates\msdn2019\*.*" "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\msdn2019\*.*" > NUL:
echo IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\SyntaxHighlighter" rmdir "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\SyntaxHighlighter" /S /Q > NUL:
IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\SyntaxHighlighter" rmdir "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\SyntaxHighlighter" /S /Q > NUL:
echo mkdir "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\SyntaxHighlighter" > NUL:
mkdir "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\SyntaxHighlighter" > NUL:
echo xcopy "C:\Program Files\VSdocman\Templates\SyntaxHighlighter\*.*" "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\SyntaxHighlighter" /S /H /R /Y /i > NUL:
xcopy "C:\Program Files\VSdocman\Templates\SyntaxHighlighter\*.*" "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\SyntaxHighlighter" /S /H /R /Y /i > NUL:
@REM HTML files that were protected against indexing will be made HTML again.
echo ren "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\*.html_rename" "*.html" > NUL:
ren "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\*.html_rename" "*.html" > NUL:
@REM delete unused files
echo IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhk" del "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhk" > NUL:
IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhk" del "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhk" > NUL:
echo IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhc" del "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhc" > NUL:
IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhc" del "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhc" > NUL:
echo IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhp" del "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhp" > NUL:
IF EXIST "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhp" del "C:\Users\shreja\autorest.csharp\samples\Purview.Scanning\VSdoc\Purview.Scanning.hhp" > NUL:
@echo All done
