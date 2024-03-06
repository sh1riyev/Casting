//boxing-unboxing

//int a = 5;

//object b = a;

//int c = (int)b;

//byte num = 50;
//int num2 = num; //byte int daxilindedir

using Casting;

int a = 5;
byte b = (byte)a; // int byte intervalina daxil deyil

Fish fish = new Fish();
Animal animal1 = fish;        //upcasting


//Animal animal12 = new Animal();

//Fish fish1 =(Fish) animal1;

Animal animal3 = new Dog();
Animal animal4 = new Fish();
Dog dog = new Dog();

//object[] datas = { 1, 2, true, "salam" };

object[] animals = { animal1, animal3, animal4, dog ,"name"};

//foreach (var item in animals)
//{
//    if(item is Animal)
//    {
//        ((Animal)item).Name = "Mesder";
//        Console.WriteLine(((Animal)item).Name);
//    }

//}

//DataList data = new();

//data[0] = "salam";
//data[1] = "sagol";

Employee employee1 = new();
employee1.Age = 23;
employee1.Id = 1;

Employee employee2 = new();
employee2.Age = 55;
employee2.Id = 2;

Console.WriteLine(employee1>employee2);