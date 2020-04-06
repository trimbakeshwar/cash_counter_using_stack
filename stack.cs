using System;
using System.Collections.Generic;
using System.Text;

namespace cash_counter_using_stack
{
    class stack
    {
        int capacity;
        int[] Stack;
      
        int top;
       public stack(int capacity)
        {
            this.capacity = capacity;
            Stack = new int[this.capacity];
            top = 0;
           
        }
        /// <summary>
        /// check stack is empty or not
        /// </summary>
        /// <returns> it return true when stack is empty</returns>
        public Boolean isEmpty()
        {
            return (top < 1);
        }

        /// <summary>
        /// if top is greter then capacity then print stack overflow
        /// else
        /// data will be store in stack at then end
        /// </summary>
        /// <param name="data">store data in stack </param>
        public void push(int data)
        {
            if(top>capacity)
            {
                Console.WriteLine("stack overflow");
               
            }
            else
            {
                Stack[top++] = data;
            }
        }
        /// <summary>
        /// if top is zero then return 0
        /// else
        /// top will be reduce by 1 and 
        /// element on this possition is removed by garbeg collector
        /// </summary>
        /// <returns>data will be return </returns>
        public int pop()
        {
            if(top<0)
            {
                return 0;
            }
            else
            {
                top = top - 1;
                int data = Stack[top];
               
                return data;
            }
        }
        /// <summary>
        /// it shows topmost element from stack
        /// </summary>
        public void peek()
        {
            Console.WriteLine("top most element is : "+Stack[top-1]);
        }
        public void display()
        {
            if(top<1)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                for(int i=top-1;i>=0;i--)
                {
                    Console.WriteLine(Stack[i]);
                }
            }
        }
    }
}
