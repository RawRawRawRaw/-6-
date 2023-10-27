using System;

namespace lib6;

public class Car
{
    //конструктор
    public Car()
    {

    }

    //конструктор
    public Car(int stamp1, int cylinders1, int power1, int stamp2, int cylinders2, int power2)
    {
        _cylinders1 = cylinders1;
        _stamp1 = stamp1;
        _power1 = power1;
        _cylinders2 = cylinders2;
        _stamp2 = stamp2;
        _power2 = power2;
    }

    //объявленные переменные для работы внутри методов
    int _stamp1;//марка 1
    int _cylinders1;//кол-во цилиндров 1
    int _power1;//мощность 1
    int _stamp2;//марка 2
    int _cylinders2;//кол-во цилиндров 2
    int _power2;//мощность 2

    //перегруженные методы

    /// <summary>
    /// 
    /// </summary>
    /// <param name="stamp1"></param>марка 1
    /// <param name="stamp2"></param>марка 2
    public void SetParams(int stamp1, int stamp2)
    {
        _stamp1 = stamp1;
        _stamp2 = stamp2;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="stamp1"></param>марка 1
    /// <param name="cylinders1"></param>кол-во цилиндров 1
    /// <param name="stamp2"></param>марка 2
    /// <param name="cylinders2"></param>кол-во цилиндров 2
    public void SetParams(int stamp1, int cylinders1, int stamp2, int cylinders2)
    {
        _cylinders1 = cylinders1;
        _stamp1 = stamp1;
        _cylinders2 = cylinders2;
        _stamp2 = stamp2;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="stamp1"></param>марка 1
    /// <param name="cylinders1"></param>кол-во цилиндров 1
    /// <param name="power1"></param>мощность1
    /// <param name="stamp2"></param>марка 2
    /// <param name="cylinders2"></param>кол-во цилиндров 2
    /// <param name="power2"></param>мощность2
    public void SetParams(int stamp1, int cylinders1, int power1, int stamp2, int cylinders2, int power2)
    {
        _cylinders1 = cylinders1;
        _stamp1 = stamp1;
        _power1 = power1;
        _cylinders2 = cylinders2;
        _stamp2 = stamp2;
        _power2 = power2;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="stamp1"></param>марка 1
    /// <param name="cylinders1"></param>кол-во цилиндров 1
    /// <param name="power1"></param>мощность1
    /// <param name="stamp2"></param>марка 2
    /// <param name="cylinders2"></param>кол-во цилиндров 2
    /// <param name="power2"></param>мощность2
    public void GetParams(out int stamp1, out int cylinders1, out int power1, out int stamp2, out int cylinders2, out int power2)
    {
        cylinders1 = _cylinders1;
        stamp1 = _stamp1;
        power1 = _power1;
        cylinders2 = _cylinders2;
        stamp2 = _stamp2;
        power2 = _power2;
    }
}
