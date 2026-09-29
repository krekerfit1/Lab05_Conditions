Console.Write("ВВедите кол-во посещений (из 19):");
int attendance = int.Parse(Console.ReadLine());
Console.Write("ВВедите средний балл по практике: ");
double practiceGpa = double.Parse(Console.ReadLine());
bool goodAttendance = attendance >= 14;
bool goodGrades = practiceGpa >= 3.0;
if (goodAttendance && goodGrades) {
    Console.WriteLine("+ Допуск к экзамену разрешон");
}
else if (!goodAttendance && goodGrades) {
    Console.WriteLine("- недостаточно посещений. Нужно отработать пропуски.");
}
else if (goodAttendance && !goodGrades) {
    Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы");    
}
else {
    Console.WriteLine("- проблемы и с посещаемостью и оценками. - казнить нельзя помиловать.");

}
