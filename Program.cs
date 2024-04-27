// using System;
// using System.Linq;
// public class Member
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public string Gender { get; set; }
//     public DateTime DoB { get; set; }
//     public string BirthPlace { get; set; }
//     public string PhoneNo { get; set; }
//     public int Age { get => DateTime.Now.Year - DoB.Year; }
//     public bool IsGraduated { get; set; }

//     public Member(string firstName, string lastName, string gender, DateTime dOb, string birthPlace, string phoneNo, bool isGraduated)
//     {
//         this.FirstName = firstName;
//         this.LastName = lastName;
//         this.Gender = gender;
//         this.BirthPlace = birthPlace;
//         this.DoB = dOb;
//         this.PhoneNo = phoneNo;
//         this.IsGraduated = isGraduated;
//     }
//     public Member()
//     {
//     }
// }
// class Assignment
// {
//     static void Main(string[] args)
//     {
//         Member mem1 = new Member("Lan", "Hoang", "Male", new DateTime(2001, 01, 17), "Haiphong", "0398903001", true);
//         Member mem2 = new Member("Truong", "Nguyen", "Male", new DateTime(1992, 03, 16), "HCMC", "0912345678", false);
//         Member mem3 = new Member("Huyen", "Luu", "Female", new DateTime(2005, 02, 24), "Hanoi", "0945394242", false);
//         Member mem4 = new Member("Hang", "Minh", "Female", new DateTime(1990, 07, 05), "Hanoi", "0945394242", true);
//         Member mem5 = new Member("Phuong", "Lan", "Female", new DateTime(2003, 08, 03), "Haiphong", "0945394242", true);
//         Member mem6 = new Member("Son", "Cao", "Female", new DateTime(2000, 09, 02), "Hue", "0945394242", false);
//         List<Member> members = new List<Member> { mem1, mem2, mem3, mem4, mem5, mem6 };
//         Console.WriteLine("a. Return list of members who is Male ");
//         FindMemberByGender(members);
//         Console.WriteLine("-----");
//         Console.WriteLine("b. Return the oldest member");
//         OldestMember(members);
//         Console.WriteLine("-----");
//         Console.WriteLine("c. Return full name of members");
//         MemberFullname(members);
//         Console.WriteLine("-----");
//         Console.WriteLine("d. Return list of birthday year ");
//         DivideBaseOnDoB(members);
//         Console.WriteLine("-----");
//         Console.WriteLine("e. Return the first member who was born in Hanoi ");
//         BirthPlaceMember(members);

//         // int i = 5;
//         // Console.WriteLine(IsPrime(i));
//     }

//     public static void FindMemberByGender(List<Member> list)
//     {
//         var listMember = from mem in list where mem.Gender == "Male" select mem;
//         PrintListMember(listMember.ToList());
//     }

//     public static void OldestMember(List<Member> list)
//     {
//         // int maxAge = (from mem in list select mem.Age).Max();
//         // var oldestMember = from mem in list
//         //                    where mem.Age == maxAge
//         //                    select mem;
//         // PrintListMember(oldestMember.ToList());

//         var oldestMember = list.OrderBy(x => x.DoB.Year).First();
//         PrintMember(oldestMember);
//     }

//     public static void MemberFullname(List<Member> list)
//     {
//         var fullNameList = from mem in list
//                            select new { mem.FirstName, mem.LastName };
//         foreach (var name in fullNameList)
//         {
//             Console.WriteLine($"{name.LastName} {name.FirstName}");
//         }
//     }
//     public static void DivideBaseOnDoB(List<Member> list)
//     {
//         var birthYear2000 = from mem in list
//                             where mem.DoB.Year == 2000
//                             select mem;

//         var birthYeargreater2000 = from mem in list
//                                    where mem.DoB.Year > 2000
//                                    select mem;

//         var birthYearless2000 = from mem in list
//                                 where mem.DoB.Year < 2000
//                                 select mem;

//         Console.WriteLine("List of members who has birth year is 2000");
//         PrintListMember(birthYear2000.ToList());
//         Console.WriteLine();
//         Console.WriteLine("List of members who has birth year is greater than 2000");
//         PrintListMember(birthYeargreater2000.ToList());
//         Console.WriteLine();
//         Console.WriteLine("List of members who has birth year is less than 2000");
//         PrintListMember(birthYearless2000.ToList());
//     }

//     public static void BirthPlaceMember(List<Member> list)
//     {
//         var birthPlaceMember = from mem in list
//                                where mem.BirthPlace == "Hanoi"
//                                select mem;
//         PrintMember(birthPlaceMember.First());
//     }

//     public static void PrintListMember(List<Member> list)
//     {
//         int i = 1;
//         foreach (var mem in list)
//         {
//             Console.WriteLine($" {i}. Full Name: {mem.LastName} {mem.FirstName} | Gender: {mem.Gender} | DoB: {mem.DoB.ToString("dd/MM/yyyy")} | Birthplace: {mem.BirthPlace} ");
//             i++;
//         }
//     }
//     public static void PrintMember(Member mem)
//     {
//         Console.WriteLine($"    Full Name: {mem.LastName} {mem.FirstName} | Gender: {mem.Gender} | DoB: {mem.DoB.ToString("dd/MM/yyyy")} | Birthplace: {mem.BirthPlace} ");
//     }
// }
