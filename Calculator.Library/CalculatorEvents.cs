using System;

namespace Calculator.Library
{
    public class CalculatorEvents
    {
        //Addition Task
        public int Addition(int x,int y)
        {
            try
            { 
                return x + y;  //returns added result
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        //Subtraction Task
        public int Subtraction(int x,int y)
        {
            try
            { 
                return x - y; //returns subtracted result
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Multiplication Task
        public int Multiplication(int x,int y)
        {
            try
            {
                return x * y; //returns multiplication result 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        //Division Task
        public int Division(int x,int y)
        {
            try
            {
                return x / y; //returns Division result 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
