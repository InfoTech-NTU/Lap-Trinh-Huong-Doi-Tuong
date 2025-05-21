# 📘 LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG

## I. Tổng quan về lập trình hướng đối tượng
- 🔹 Lập trình cấu trúc (Structural Programming) 
- 🔹 Phương pháp lập trình hướng đối tượng (Object Oriented Programming) 
- 🔹 Các nguyên lý cơ bản của lập trình hướng đối tượng
  - Trừu tượng hóa (Abstraction)
  - Bao đóng (Encapsulation)
  - Thừa kế (Inheritance)
  - Đa hình (Polymorphism)
- 🔹 📝 [Bài tập minh họa lập trình cấu trúc](https://github.com/nd-hung/oop/blob/main/docs/topics/overview/code/structured-programming/Program.cs)

---

## II. Nền tảng .NET và C#
- 🔹 Ngôn ngữ lập trình C# 
- 🔹 Các kiểu dữ liệu của C#
- 🔹 🍀[Nền tảng .NET](https://learn.microsoft.com/en-us/dotnet/)  

---

## III. Lớp và đối tượng - Classes and Objects
- 🔹 Cài đặt lớp  
- 🔹 Thiết lập tính bao đóng  
- 🔹 Tạo, sử dụng và hủy đối tượng
- 🔹 Hàm thiết lập (constructor)
- 🔹 Hàm hủy (destructor/finalizer)  
- 🔹 Lớp tĩnh, thành phần tĩnh
- 🔹 📝 [Ví dụ minh họa static class](https://github.com/nd-hung/oop/blob/main/docs/topics/classes-and-objects/code/TemperatureConverter/Program.cs)
- 🔹 Con trỏ this
- 🔹 Danh sách đối tượng
  - Danh sách tĩnh (array)
  - Danh sách động (list)
- 🔹 Nạp chồng phương thức (method overloading)
- 🔹 Nạp chồng toán tử (operator overloading)
- 🔹 📝 [Ví dụ minh họa](https://github.com/nd-hung/oop/blob/main/docs/topics/classes-and-objects/code/OperatorOverloading/Program.cs) 

---

## IV. Thừa kế - Inheritance
- 🔹 Tổng quát hóa, đặc biệt hóa 
- 🔹 Cài đặt thừa kế
- 🔹 📝 [Các ví dụ thừa kế](https://github.com/nd-hung/oop/tree/main/docs/topics/inheritance/code)
- 🔹 Quy tắc thừa kế
- 🔹 Lớp niêm phong (sealed class)
- 🔹 Nạp chồng phương thức của lớp cơ sở
- 🔹 Ẩn phương thức của lớp cơ sở
- 🔹 📝 [Ví dụ minh họa](https://github.com/nd-hung/oop/tree/main/docs/topics/inheritance/code/HidingBaseMethods)  

---

## V. Đa hình - Polymorphism
- 🔹 Dẫn nhập
- 🔹 Kỹ thuật đa hình
- 🔹 📝 [Ví dụ](https://github.com/nd-hung/oop/tree/main/docs/topics/polymorphism/code/Shape/)
- 🔹 Lớp trừu tượng - AbstractClass, phương thức trừu tượng - Abstract Method
- 🔹 Sự khác nhau giữa từ khóa new và override
- 🔹 Giao diện (interface)
- 🔹 Đa thừa kế
- 🔹 📝 [Ví dụ đa thừa kế](https://github.com/nd-hung/oop/tree/main/docs/topics/polymorphism/code/MultipleInheritance)

---

## 💡 Một số gợi ý - tham khảo
### 1. Một số sách/tài liệu

| STT | Tên tài liệu     | Tác giả                                                     |
|-----|--------------|-----------------------------------------------------------------|
| 1   | Lập trình hướng đối tượng      | Trần Đan Thư, Đinh Bá Tiến, Nguyễn Tấn Trần Minh Khang - NXB Khoa học kỹ thuật, 2010|
| 2   | C# Programming Yellow Book     | Rob Miles, 2016|
| 3   | Beginning C# Object-Oriented Programming    | Dan Clark, 2015|
| 4   | Lập trình hướng đối tượng với C++       | Lê Đăng Hưng, Tạ Tuấn Anh, Nguyễn Hữu Đức, Nguyễn Thanh Thủy - NXB Khoa học kỹ thuật, 2005|
| 5   | C++ How to Program, 10th edition     | Paul Dietel - Pearson, 2017|
| 6   | ...          | ...                                                            |

### 2. Tài liệu trực tuyến

| STT | Tên tài liệu     |
|-----|--------------|
| 1   | [Microsoft .NET documentation](https://learn.microsoft.com/en-us/dotnet/)|
| 2   | [Microsoft C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)|
| 3   | [Learn to code in Visual Studio - Microsoft](https://visualstudio.microsoft.com/vs/getting-started/)|
| 4   | [Create .NET console applications using Visual Studio Code](https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0)|
| 5   | [C# Tutorial - W3Schools](https://www.w3schools.com/cs/index.php)|
| 6   | ...          |

### 3. Một số từ khóa quan trọng

| STT | Từ khóa                   | Chức năng                                                       |
|-----|-----------------------------|-----------------------------------------------------------------|
| 1   | public                 | Truy cập được từ bất kỳ đâu, cả trong và ngoài assembly (dự án).                              |
| 2   | private  | Chỉ truy cập được trong class hoặc struct chứa nó.|
| 3   | protected                  | Truy cập được trong class hiện tại và class dẫn xuất (kế thừa).|
| 4   | internal                | Truy cập được trong cùng một assembly (project), nhưng không từ bên ngoài.|
| 5   | abstract                      | Dùng để khai báo lớp hoặc phương thức trừu tượng|
| 6   | interface                    | Khai báo giao diện, chỉ chứa định nghĩa phương thức, không có thân|
| 7   | virtual    | Từ khóa virtual được dùng để cho phép một phương thức trong lớp cha có thể được ghi đè (override) trong lớp con.|
| 8   | override                   | Dùng trong lớp con để ghi đè (override) một phương thức virtual hoặc abstract trong lớp cha|
| 9   | new                      | Dùng để ẩn (hide) một thành viên kế thừa từ lớp cha, khi bạn không muốn override mà muốn viết lại từ đầu|
| 10  | static             | Dùng để khai báo biến, phương thức, hàm khởi tạo, hoặc lớp mà không cần tạo đối tượng.|
| 11  | ...                         | ...                                                                    |

---

>📑 Một số thông tin tham khảo, rất mong sẽ hỗ trợ được mọi người
