using System;
using System.Collections.Generic;

public abstract class Goals
{
    private bool isChecked;
    private string _name;

    private string _type;

    private int _point;

    public bool IsChecked
    {
        get { return isChecked; }
        set { isChecked = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public int Point
    {
        get { return _point; }
        set { _point = value; }
    }


    public Goals(string name, string type, int point)
    {

        IsChecked = false;
        Name = name;
        Type = type;
        Point = point;

    }

    public virtual void Display(int i)
    {

    }

    public virtual int CompletedGoals()
    {
        if (isChecked == false)
        {
            isChecked = true;
            return _point;

        }
        else
        {
            return 0;

        }
    }

    public virtual string SaveFormat()
    {
        return "";
    }
}


