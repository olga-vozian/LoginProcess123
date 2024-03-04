Feature: LoginSteps


Scenario: Login to the webSites <companyName>
	Given the user navigate to login page of "<companyName>"
	And user clicks on "<companyLoginButton>"
	When user finds "<companyUserNameField>" and inputs "ana.munteanu@gmail.com"
	And user finds "<companyPassword>" field and inputs "ana1munteanu1987"
	Then user finds and clicks on "<companySentButton>" 

	Examples:
      | companyName | companyLoginButton  | companyUserNameField  | companyPassword   | companySentButton  |
      | Volta       | VoltaLoginButton    | VoltaUserNameField    | VoltaPassword     | VoltaSentButton    |
      | Supraten    | SupratenLoginButton | SupratenUserNameField | SupratenPasssword | SupratenSentButton |


 Scenario: Login to the webSite Yahoo
	Given the user navigate to login page of "<companyName>"
	And user clicks on "<companyLoginButton>"
	When user finds "<companyUserNameField>" and inputs "<companyEmail>"
	Then user finds and clicks on "<companyNextButton>"
	When user finds "<companyPassword>" field and inputs "olga1vozian1987"
	Then user finds and clicks on "<companyNextButton>" 

	Examples:
      | companyName | companyLoginButton | companyUserNameField | companyPassword | companyNextButton | companyEmail          |
      | Yahoo       | YahooLoginButton   | YahooUserNameField   | YahooPasssword  | YahooNextButton   | olga.vozian@yahoo.com |
