This is a project from old source [LatexMath2MathML](https://github.com/smallgreycreatures/LatexMath2MathML)

I convert it to .Net Standard Library and then publish in nuget.
[![Nuget](https://img.shields.io/nuget/v/LatexToMathML?color=purple)](https://www.nuget.org/packages/LatexToMathML/)
[![NuGet version (LatexToMathML)](https://img.shields.io/nuget/dt/LatexToMathML)](https://www.nuget.org/packages/LatexToMathML)

# LatexMath2MathML
This is a version of Latex2MathML(https://latex2mathml.codeplex.com) with subtracted functionality. This version aims at only handling the Mathematic of LaTeX and convert it to MathML.

* Added functionality
Support for small, big and var greek letters (the code for \phi and \varphi might be wrong)

Support for all relationship operators mentioned on https://en.wikibooks.org/wiki/LaTeX/Mathematics

Exception handling: When braces are missing exceptions are thrown. This have to be handled through eventlistning because of multi threading.

* Test cases
Test cases are added to prove the functionality and can be found in Tests.cs.
