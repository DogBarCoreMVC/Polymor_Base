using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor_Base
{
    public class Animal
    {
        public virtual void Goes()//สร้าง method และมี keyword virtual เพื่อบอกว่าให้คลาสลูกไปกำหนดการทำงานในรูปแบบของตัวเองได้
        {
            Console.WriteLine("Goes like an Animal");
        }
        public Animal(int num)//สร้าง constructor และให้ผ่านค่าเข้ามาใน parameter (num คือการกำหนดให้เป็นค่าว่างๆไว้รอรับค่า)
        {
            Console.WriteLine("Animal ctor:" + num);//แสดงผลทั้งสอง class
        }
    }
    public class Dog : Animal
    {
        public override void Goes()//สร้าง method มี keyword override เป็นการบอกว่า method นี้จะทำการเขียนทับ method เดิมจากคลาสแม่
        {
            base.Goes();//base คือ keyword ที่จะบอกว่าให้กลับไปทำงานใน method เดิม คือคลาสแม่ แล้วเอาค่าในนั้นมาแสดงผล คือค่านี้("Goes like an Animal")
            Console.WriteLine("Woof Woof");//คำสั่งนี้จะไม่ถูกแสดงผลใน class Animal แต่จะแสดงผลใน class Dog
        }
        public Dog(int num, string name) : base(num)//keyword base จะกลับไปทำงานใน constructor ของ class Animal ตัวแปร(int num คือตัวเดียวกัน ค่าที่รับคือค่าเดียวกัน) คือ การทำงานครั้งแรกจะมาทำงานใน Class Animal ค่าที่กำหนดไว้คือ 15 (int num = 15) รอบสองเข้ามาทำงานใน Class Dog ค่าที่กำหนดไว้คือ (30 int num = 30)
        {
            Console.WriteLine("Animal ctor:" + num + name);//แสดงผลใน class Dog
        }
        //base ใช้ได้ทั้ง method และ constructor 
    }
}
