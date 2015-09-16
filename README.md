# ASP.NET MVC / Kendo UI Numeric Textbox and client validation

This is a simple project to demonstrate that there appears to be an incompatability between Microsoft jQuery Unobstrusive validation and the Kendo UI Numeric textbox

The project comprises the following:

1. ASP.NET MVC 5.2.3 - based off an empty project template / Visual Studio 2013
2. jQuery 2.1.4
3. Kendo UI  Q2 2015 SP2 - latest version from CDN
4. Bootstrap 3.3.5
5. jQuery Validation 1.1.14

The MVC project has a single controller, called Home with the following Actions:

1. Index  - shows a list of people added to a static List
2. Create - demonstrates the problem with Kendo UI Numeric Textbox and client validation
3. CreateWorking - demonstrates the correct behaviour when client validation is disabled

## Problem:

* Consider a model / entity class in C# with a nullable, decimal property that is marked with the Required attribute.
* Create a standard MVC create view using @Html helpers for a Form, EditorFor and ValidationMessageFor for this model class.
* When EnableClientValidation is set to true, when clicking the Submit button on the form, no validation message is shown and the form is sent via a post back
* MVC model binding will detect the model error and return the model back to the View
* Now enter a value into the numeric textbox and click Submit. Note that the value returned to the Controller is always 0.00


# Steps to reproduce

* Run the Web Application
* Click the Create (not working link)
* Type a name in the Name textbox and click submit
* Observe that the form is sent to the controller and returned due to model validation error and the validation text is displayed
* Enter a value into the numeric textbox and click submit again
* note that the value in the list is 0.00 and not the value entered

Perform the exact same steps with the link on Create (working), and note that the correct value is stored when posting back the second time


