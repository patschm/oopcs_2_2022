using TheCompany;

Reinout reinout = new Reinout();
Thijs thijs = new Thijs();
Bokito bok = new Bokito();
ACME company = new ACME();

company.Hire(reinout);
company.Hire(thijs);
company.Hire(bok);

company.Stoomfluit();
