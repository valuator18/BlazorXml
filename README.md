In order to see the error, the project must be published and ran outside of a development environment.

`dotnet publish -o publish -r win-x64 -c Release`

Then run `.\BlazorXml.exe` inside the publish folder and navigate to http://localhost:5000.
The page on initial load will be running with Blazor Server since the project uses the `InteractiveAuto` rendering mode.
In this mode, clicking the 'Deserialize XML' button should work. Refresh the page, it should now be running
in Blazor WebAssembly. Clicking 'Deserialize XML' will now throw the error which can be seen in the browser console.
