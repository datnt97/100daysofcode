using ObserverDesignPattern.Exam;
using ObserverDesignPattern.Stock;
using ObserverDesignPattern.StructuralCode;
using System;

//StructuralObserver();
//ExecuteStockObserver();
ExecuteExamObserver();


static void StructuralObserver()
{
	ConcreteSubject subject = new ConcreteSubject();

	subject.Attach(new ConcreteObserver("X", subject));
	subject.Attach(new ConcreteObserver("Y", subject));
	subject.Attach(new ConcreteObserver("Z", subject));
	subject.Attach(new ConcreteObserver("W", subject));



	subject.SubjectState = "ABC";
	subject.Notify();
	subject.SubjectState = "101";
	subject.Notify();
}

static void ExecuteStockObserver()
{
	IBM ibm = new IBM("IBM", 120.00);
	ibm.Attach(new Investor("Sorros"));
	ibm.Attach(new Investor("Berkshire"));

	ibm.Price = 130.30;
	ibm.Price = 150.00;
	ibm.Price = 160.00;
	ibm.Price = 200.05;

	Console.ReadKey();
}

static void ExecuteExamObserver()
{
	MathExam mathExam = new MathExam("12C4", 10);
	mathExam.Attach(new Student("DNT", 10));
	mathExam.Attach(new Student("OO1", 10));
	mathExam.Attach(new Student("100", 10));
	mathExam.Attach(new Student("010", 10));

	mathExam.MaxGrade = 50;
	mathExam.MaxGrade = 100;

	Console.ReadKey();
}
