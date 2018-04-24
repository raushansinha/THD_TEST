# THD Test

This repository contains 3  applications.
1. ResistorOhmCalculatorService
   Asp core 2.0 web API application to expose REST API for to calculate Resistor Ohm value for given Band Color.
   I have configured swagger, so service can be tested in browser itself.
   Service will run as below URL in localhost
   http://localhost:14009/swagger/
   
   To run this application, open application and run (Service.jsp)
   

2. Asp core 2.0 MVC client with simple UI and xUnit test to consume above service and display Resistor Ohm for selected Band Color
   This client application will run as below URL in localhost
   http://localhost:30349/
   
   To run this application, open in VS 2017 and run (keep above service running on same port) (MVC Client.jsp)

3. React client with simple UI to consume above service and display Resistor Ohm for selected Band Color.
  
	To run this client run below commands in application folder
		npm install
		npm start
	 
	Then open  http://localhost:8080/ in browser. (React.jsp)
