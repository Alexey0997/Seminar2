// Задача с собакой и друзьями
// Два друга движутся навстречу с заданной скоростью. Скорость первого — _ м/с, второго — _ м/с. 
// У них есть собака, которая бегает со скоростью _ м/с. 
// Когда друзья начинают свой путь, собака бежит от одного друга к другому, добегает, разворачивается и тут же бежит обратно. 
// Сколько раз собака перебежит от одного друга к другому, пока они не встретятся.
Console.Clear();
Console.WriteLine("Введите дистанцию между друзьями не менее 10 метров: ");
int distance = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите скорость первого друга (м/с): ");
int FirstFriendSpeed = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите скорость второго друга (м/с): ");
int SecondFriendSpeed = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите скорость собаки (м/с): ");
int DogSpeed = int.Parse(Console.ReadLine()!);
int friend = 2; // Направление движения собаки от первого друга ко второму. 
int count = 0;  // Количество раз, которое пробежит собака от одного друга к другому.
int time = 0;
while(distance >= 10)
{
    if(friend == 2)
    {
        time = time + distance/(SecondFriendSpeed + DogSpeed);
        distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
        friend = 1;
    }
    else
    {
        time = time + distance/(FirstFriendSpeed + DogSpeed);
        distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
        friend = 2;
    }
count++;
}
Console.WriteLine($"Собака пробежит от одного друга к другому {count} раз(а).");
