open System
open System.Drawing
open System.IO
open System.Windows.Forms
//создание нашей формы
let Form1 =new Form(Text = "Калькулятор действительных чисел" ,Width = 400, Height = 300)
let Edit1 = new TextBox(Width=100, Left=100, Height=25, Text="6")
let Edit2 = new TextBox(Top=20,Width=100,Left=100, Height=25, Text="3") 
let button1 = new Button(Text="СЛОЖЕНИЕ",  Width=100, Height=25)
let button2 = new Button(Text="ВЫЧИТАНИЕ", Top=25,  Width=100, Height=25)
let button3 = new Button(Text="УМНОЖЕНИЕ", Top=50,  Width=100, Height=25)
let button4 = new Button(Text="ДЕЛЕНИЕ", Top=75,  Width=100, Height=25)
let button5 = new Button(Text="ДЕЛЕНИЕ НА 0", Top=100, Width=100, Height=25)
Form1.Controls.Add(Edit1)
Form1.Controls.Add(Edit2)
Form1.Controls.Add(button1)
Form1.Controls.Add(button2)
Form1.Controls.Add(button3)
Form1.Controls.Add(button4)
Form1.Controls.Add(button5)
let Summ _ = MessageBox.Show(string(float(Edit1.Text)+ (float(Edit2.Text))), "Сум-ма") |>ignore
let Minus _ =  MessageBox.Show(string(float(Edit1.Text)-(float(Edit2.Text))), "Раз-ность") |>ignore
let Umnoj _ =  MessageBox.Show(string(float(Edit1.Text)  *  (float(Edit2.Text))), "Умножение") |>ignore
let  Del _ =   MessageBox.Show(string(float(Edit1.Text)/   (float(Edit2.Text))), "Деление") |>ignore
let  Dot _ =   MessageBox.Show("На 0 делить нельзя!") |>ignore
let _= button1.Click.Add(Summ)
let _= button2.Click.Add(Minus)
let _= button3.Click.Add(Umnoj)
let _= button4.Click.Add(Del)
let _= button5.Click.Add(Dot)
// Запускаем форму
do Application.Run(Form1)

























