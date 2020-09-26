# C# 

## By lavoz_sz@qq. com



## C#基础

### 数据类型

#### 值类型

|  类型   |              描述               |              范围               | 默认值 |
| :-----: | :-----------------------------: | :-----------------------------: | ------ |
|  byte   |             布尔值              |           True/False            | False  |
|  char   |          8位无符号整数          |             0到255              | 0      |
| decimal | 128精确的十进制值,28-29有效位数 |                                 | 0.0M   |
| double  |        64位双精度浮点数         |                                 | 0.0D   |
|  float  |        32位单精度浮点数         |                                 | 0.0F   |
|   int   |       32位有符号整数类型        | -2,147,483,648 到 2,147,483,647 | 0      |
|  long   |       64位有符号整数类型        |                                 | 0L     |
|  sbyte  |          8位有符号整数          |            -128到127            | 0      |
|  short  |       16位有符号整数类型        |                                 | 0      |
|  uint   |       32位无符号整数类型        |       0 到 4,294,967,295        | 0      |

+ 可以使用sizeof方法, 获取储存尺寸(字节数)

#### 引用类型

+ 不包含储存在变量中的实际数据, 但它们包含对变量的引用
+ 内置引用类型object, dynamic, string

##### 对象(Object)类型

1. Object类型是所有数据类型的终极基类
2. Object 类型可以被分配任何其他类型(值类型, 引用类型, 预定义类型或者用户自定义类型)的值, 在分配值之前需要类型转换.

```C#
object obj;
obj = 100; //装箱
```

##### 动态(Dynamic) 类型

+ 可以储存任何类型的值在动态数据类型变量中. 这些变量的类型检查是在运行时发生的.

```c#
dynamic <var_name> = value;
dynamic d = 20;
```

+ 动态类型与对象类型相似, 但是对象类型变量的类型检查是在编译时发生的, 而动态类型变量的检查是在运行时发生的.

##### 字符串(String)类型

```C#
//@符号相当于转义字符串 python中的r''
string str = "C:\\"
string str2 = @"C:\"
Console.WriteLine(str == str2); // 结果为True
//@字符串还有多行字符串的作用
```

#### 指针类型

+ 指针类型变量储存另一种类型的内存地址.
+ C# 中的指针与C, C++ 指针功能相同

```C#
type* identifier;
char* cptr;
int iptr;
```

### 类型转换

+ ToBoolean等(转换为布尔类型, 其他同理)

+ ToByte

+ ToChar

+ ToDateTime

+ ToDecimal

+ Toduble

+ ToInt16

+ ToInt32

+ ToInt64

+ ToSbyte

+ ToSingle

+ ToString

+ ToUInt16

+ ToUInt32

+ ToUint64

  

### 变量

+ 命名规则参考C++, Java

### 常量

+ 在定义后无法修改 
+ 使用const 定义

```c#
using System;
namespace ConstTest
{
    class SampleClass
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass(int p1, int p2) {
            x = p1;
            y = p2;
        }

    }
}

class App
{
    public void Main(args[]){
        SampleClass sc = new SampleClass(11, 22);
        Console.WriteLine("x = {0}", sc.x) //可以直接访问类变量
        //类常量需要使用类来访问, 实例化后也访问不到
         c1 = SampleClass.c1
            
    }
}


```

### 运算符

+ 同Python

### C# 判断

```c#
if(express){

}else{
    
}
```

+ 同Js

### 循环

 #### for 循环

```C#
using System;
namespace Loops{
    class Program{
        static void Main(string[] args){
            for (int a = 10; a < 20; a++){
                Console.WriteLine("a的值 {0}", a)
            }
        }
    }
}
```

#### for each 循环

```C#
using System;
namespace Program2{
    class ForEachLoop{
        public void loopArr(){
            int[] numArr = new int[]{1,2,3,4,5,6,7};
            foreach(int num in numArr){
               	Console.WriteLine(num);
            }
        	// 循环输出 1,2,3,4,5,6,7
        }
    }
}
```

### C# 封装

+ public: 所有对象都可以访问
+ private 对象本身在内部可以访问
+ protected 只有该类对象及其子对象可以访问
+ internal 同一个程序集的对象可以访问
+ protected internal 访问仅限于当前程序集或派生自包含类的对象

#### Public访问修饰符

+ 同Java

#### Private访问修饰符

+ 同Java(实例也不能访问, 只有类内部能访问)

#### Protected 访问修饰符

+ 允许子类访问它的基类的成员变量和成员函数

#### internal 访问修饰符

+ 允许一个类将其成员变量和成员函数暴露给当前程序中的其他函数和对象, 带有internal 访问修饰符的任何成员可以被定义在该新成员所定义的应用程序内的任何类或者方法访问

  ```C#
  using System;
  namespace RectangleApplication{
      class Rectangle{
          internal double length;
          internal double width;
      }
      double GetArea(){
          return length * width;
      }
      public void display(){
          Console.WriteLine("长度: {0}", length);
          Console.WriteLine("宽度: {0}", width);
          Console.WriteLine("面积: {0}", GetArea());
      }
      class Execute{
          static void Main(string[] args){
              Rectangle r = new Rectangle();
              r.length = 4.5;
              r.width = 3.5;
              r.display();
          }
      }
      
  }
  ```

  #### Protected Internal

  + 允许在本类, 派生类或者包含该类的程序集中访问.

  

### 方法

+ 同Java (命名规则: 方法首字母大写)



### 可空类型

+ nullable类型 : 可空类型可以表示其基础值类型正常范围内的值再加上一个null的值.

+ 使用方法:

  ```C#
  data_type? name = null;
  ```

  ```C#
  using System;
  namespace CalculatorApp{
      class NullabalesAtShow{
          static void Main(string[] args){
              int? num1 = null;
              int? num2 = 45;
              double num3 = new double?();
              bool? boolVal = new bool?();
              
              //显示
              Console.WriteLine("显示可空类型的值: {0}, {1}, {2}", num1, num2, num3);
  			num1 = 11;
              num3 = 2.4;
              Console.WriteLine("显示可空类型的值 {0}, {1}, {2}", num1, num2, num3);	
          }
          
          
      }
  }
  ```

  

### C# 数组

+ 使用方法: datatype[] arrName;

+ 初始化数组:  参考Java,Go

  ```C#
  double[] balence = new double[10]; //创建一个大小为10的double类型数组
  ```

  

+ 数组赋值

  - 使用索引复制给一个单独的数组元素(参考其他语言)

    ```C#
    dounle [] balence = new double[10];
    balence[0] = 4500.0;
    ```

  - 声明数组时给数组赋值

    ```c#
    double[] balance = { 2340.0, 4523.69, 3421.0};
    ```

  + 创建并初始化一个数组

    ```C#
    int [] marks = new int[5] {99, 98, 92, 97, 95};
    //也可以省略数组大小
    int [] marks = new int[] {99, 98, 92, 97, 95};
    ```

  + 创建一个数组复制到另一个数组变量中, 它们会指向相同的内存地址

    ```C#
    int [] marks = new int[] {99, 98 ,92, 97, 95};
    ```

    

+ 访问数组元素 通过索引访问(参考其他语言)

```C#
double salary = balence[9];
```

#### 数组细节

##### 多维数组

```C#
string[,] names;
```

+ 创建多维数组

  + ```C#
    string[,] name = new String[2,3]{
    	{"1", "2", "3"},
    	{"4", "5", "6"}
    }
    ```

    

  + 三维数组同理

    ```c#
    int [ , , ] m;
    ```

+  初始化多维数组

  ```C#
  int[, ] a = new int [3, 4] {
      {0, 1, 2, 3},
      {4, 5, 6, 7},
      {8, 9, 10, 11}
  }
  ```

+ 访问二维数组

  ```C#
  using System;
  nameapace ArrayApplication{
      class MyArray{
          static void Main(string args){
              /*五行两列数组*/
              int[,] a = new int[5, 2] {
                  {0, 0},{1, 2}, {2, 4}, {3, 6}, {4, 8}
              }
              
              for(int i = 0; i< 5; i++){
                  for(j = 0; j < 2; j++){
                      Console.WriteLine("a[{0}, {1} = {2}", i, j, a[i, j])
                  }
              }
          }
      }
  }
  ```

  

#### 交错数组

+ 即数组的数组

```c#
int [][] scores;
```

+ 声明一个数组不会在内存中创建数组.

```C#
int[][] scores = new int[5][];
for (int i = 0; i< scores.Length; i++){
	scores[i] = new int[4];
}

// 
```

```C#
using System;
namespace ConsoleApp2
{
    public class MyArray
    {
        public void Show(){
            int[][] a = new int[][]{
                new int[]{0, 0}, new int[]{1, 2},
                new int[]{2, 4}, new int[]{3, 6},
                 new int[]{4, 8}
            };
            
            int i, j;
            //输出
            for (i = 0; i< 5; i++){
                for (j = 0; j< 2; j++){
                    Console.WriteLine($"第{i}行-{j}列, {a[i][j]}");
                }
            }

        }
    }
}
```

#### 传递数组给函数

```C#
namespace ConsoleApp2
{
    public class ArrayParam
    {
        public static double GetAverage(int[] arr, int size){
            double avg;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }
    }
}
```

#### 参数数组

##### params 关键字

+ 在使用数组作为形参时, C#提供了params关键字, 使调用数组为形参的方法时, 即可以传递数组实参, 也可以传递一组数组元素, 使用格式为

  ```C#
  public 返回类型 方法名(params 类型名称[] 数组名称)
  ```

  ```C#
  namespace ConsoleApp2
  {
      public class ArrayApplication2
      {
          public int AddElements(params int[] arr){
              int sum = 0;
              foreach (int i in arr){
                  sum += i;
              }
              return sum;
          }
      }
      
      static void Main(string args[]){
          new ArrayApplications().AddElements()
      }
  }
  ```

#### Array类

| 方法        | 属性&描述                                        |
| ----------- | ------------------------------------------------ |
| IsFixedSize | 获取一个值, 该值只是数组是否带有固定大小         |
| IsReadOnly  | 指示数组是否只读                                 |
| Length      | 获取一个32位整数. 表示所有维度的数组中的元素总数 |
| LongLength  | 获取一个64位整数, 同上                           |
| Rank        | 获取数组的维度                                   |

+ 详细查看文档



###  C#字符串(String)

#### 创建字符串

+ string变量指定字符串
+ 通过String类构造函数
+ 字符串串联运算符 (+)
+ 通过检索熟悉或调用一个返回字符串的方法
+ 通过格式化方法来转换一个值或对象为他的字符串表示形式

```C#
using System;
namespace ConsoleApp2.StringClass
{ class StringApp{
        public void Show(){
            //字符串, 字符串连接
            string fname, lname;
            fname = "Rowan";
            lname = "Atkson";
            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);
            //构造函数
            char[] letters = {'H', 'e', 'l', 'l', 'o'};
            string greetings = new String(letters);
            Console.WriteLine("Greetings: {0}", greetings);
                
            // 方法返回字符串
            string[] sarray = {"Hello", "From", "Tutorials", "Point"};
            string message = String.Join(" ", sarray);
            Console.WriteLine($"Message {message}");  
            //用于转换值得格式化方法
            DateTime waiting = new DateTime(2020, 9, 25, 13, 33, 24);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
        }
    }
}
```

####  String 类的方法

| 方法                                                 | 描述                                                         |
| ---------------------------------------------------- | ------------------------------------------------------------ |
| Compare(string str1, string str2)                    | 比较两个指定的string对象, 并返回一个表示它们在排列顺序中的相对位置的整数 |
| Compare( string strA, string strB, bool ignoreCase ) | 比较两个指定的 string 对象，并返回一个表示它们在排列顺序中相对位置的整数。但是，如果布尔参数为真时，该方法不区分大小写。 |
| Concat(string str0, string str1)                     | 连接两个string对象                                           |
| ..str3                                               | 连接三个string对象                                           |
| ...str3, ...str4                                     | 连接四个string对象                                           |
| Contains(string val)                                 | 指定字符串是否出现在字符串中                                 |
| Copy(string str)                                     | 创建一个与指定字符串具有相同值得新的String对象               |
| CopyTo                                               |                                                              |
| EndsWith                                             | 结尾是否以指定字符匹配                                       |
| Equals                                               |                                                              |
| Equals(a, b)                                         |                                                              |
| Format(str, obj)                                     |                                                              |
| IndexOf(char val)                                    | 指定字符索引                                                 |

+ 更多查看文档



### 结构体

+ 必须使用struct语句

  ```C#
  struct Books{
      public string title;
      public string author;
      public string subject;
  }
  ```

  #### 和类的区别

  + 结构体无法直接赋值
  + 需要复用/ 继承选用类

  ```C#
  using System;
  namespace ConsoleApp2.Structure
  {
  
      struct Book{
          public string title;
          public string author;
          public string subject;
          public int book_id;
      }
      public class TestStructure
      {
          public static void Show(){
              Book Book1;
              Book Book2;
  
              //Book1 详细描述
              Book1.title = "C Programming";
              Book1.author = "Nuha Ali";
              Book1.subject = "C Programming";
              Book1.book_id = 6498407;
  
              //Book2 详细描述
              Book2.title = "Telecom";
              Book2.author = "Zara";
              Book2.subject = "Telecom Billing";
  
              //打印Book1信息
              Console.WriteLine($"Book1 title: {Book1.title}");
              Console.WriteLine($"Book1 author: {Book1.author}");
              Console.WriteLine($"Book1 subject: {Book1.subject}");
              Console.WriteLine($"Book1 book_id: {Book1.book_id}");
  
          }
      }
  }
  ```

### 枚举(Enum)

+ 语法

  ```C#
  enum <enum_name>{
  	enumeration list
  }
  ```

  ```C#
  using System;
  namespace ConsoleApp2
  {
      public class TestEnum
      {
          enum Day //默认情况 第一个枚举值为0
          {
              //0, 1, 2, 3, 4...
              Sun, Mon, Tue, Web, Thu, Fri, Sat
          }
  
          public static void Show(){
              int x = (int)Day.Sun;
              int y = (int)Day.Fri;
              Console.WriteLine("Sun = {0}", x);
              Console.WriteLine("Fri = {0}", y);
          }
  
      }
  }
  ```

### class(类) 

+ 类似Java, 但没有this

#### 构造函数

+ 同Java (同名函数为构造函数)

#### 析构函数

+ 析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。析构函数不能继承或重载。

```C#
using System;
/*
析构函数
*/
namespace ConsoleApp2
{
    public class Line
    {
        private double length;
        public Line(){
            Console.WriteLine("对象已经创建");
        }

        ~Line(){
            Console.WriteLine("对象已经删除");
        }

        public void setLength(double len){
            length = len;
        }

        public double getLength(){
            return length;
        }

        public void Show(){
            setLength(6.0);

            Console.WriteLine("线条的长度: {0}", getLength());
        }
    }
}
```

### 继承

```C#
namespace ConsoleApp2
{
    public class Shape
    {
        protected int width;
        protected int height;
        public void setWidth(int w){
            width = w;
        }

        public void setHeight(int h){
            height = h;
        }
    }


    class Rectangle: Shape{
        public int getArea(){
            return (width * height);
        }
    }
}
```



#### 多态性

##### 静态多态性

##### 函数重载

+ 方法重载

##### 动态多态性

##### 运算符重载

```C#
using System;
namespace ConsoleApp2
{
     class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double getVolume(){
            return length * breadth * height;
        }

        public void setLength(double len){
            length = len;
        }
        public void setBreadth(double bre){
            breadth = bre;
        }

        public void setHeight(double hei){
            height = hei;
        }

        public static Box operator+ (Box b, Box c){
            Box box = new Box();
            box.length = b.length + c.length;
            return box;

        }
    }
}
```

```C#
stativ void Main(string[] args){
    Box box1 = new Box();
            Box box2 = new Box();
            //Box box3 = new Box();
            double volume;

            box1.setLength(6.0);
            box1.setBreadth(7.0);
            box1.setHeight(5.0);

            //box2 
            box2.setLength(16.0);
            box2.setBreadth(17.0);
            box2.setHeight(15.0);
            // box1的体积
            volume = box1.getVolume();
            Console.WriteLine($"box1 的体积是: {volume}");
            
            //Box2 的体积
            volume = box2.getVolume();
            Console.WriteLine($"box2 的体积是: {volume}");

            //Box3
            Box box3 = box1 + box2;
            volume = box3.getVolume();
            Console.WriteLine($"box3 的体积是: {volume}");
}
```

+ 重载操作符, 可以直接把类用操作符(+-*/等)操作

  | 运算符                                | 描述                                         |
  | ------------------------------------- | -------------------------------------------- |
  | +, -, !, ~, ++, --                    | 这些一元运算符只有一个操作数，且可以被重载。 |
  | +, -, *, /, %                         | 这些二元运算符带有两个操作数，且可以被重载。 |
  | ==, !=, <, >, <=, >=                  | 这些比较运算符可以被重载                     |
  | &&, \|\|                              | 这些赋值运算符不能被重载                     |
  | +=, -=, *=, /=, %=                    | 不能被重载                                   |
  | =, ., ?:, ->, new, is, sizeof, typeof | 不能被重载                                   |



### 接口



## C#高级教程

