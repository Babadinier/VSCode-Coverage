# VSCode-Coverage

<b>Install pluggins:</b><br>
<ul>
  <li>Coverage Gutters - Reads in the lcov.info file (name matters) and highlights lines with color</li>
  <li>.NET Core Test Explorer - Discovers tests and gives you a nice explorer.
  <li>Coverlet - The start of .NET Core Code Coverage</li>
</ul>

<div>
To view coverage in VSCode, launch task 'test with coverage' <br>
or <br>
use command in terminal : <br>
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info .\PrimeService.Tests.info .\PrimeService.Tests
</div>
<br/>
<div>
  Don't forget to click on 'Watch' in the VS Code Status Bar.
</div>

<div>
  <h2>Reference</h2>
  <p>https://www.hanselman.com/blog/AutomaticUnitTestingInNETCorePlusCodeCoverageInVisualStudioCode.aspx</p>
</div>
