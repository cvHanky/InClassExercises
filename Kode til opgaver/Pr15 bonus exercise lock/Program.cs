using System;

namespace Pr15_bonus_exercise_lock
{
    internal class Program
    {
        public class Vault
        {
            private LockState state;

            public LockState State
            {
                get { return state; }
                set { state = value; }
            }
            public Vault(LockState state)
            {
                State = state;
            }
            public void LockVault()
            {
                if (State != LockState.Open && State != LockState.Locked)
                {
                    State = LockState.Locked;
                }
                else
                    Console.WriteLine("Action not allowed");
            }
            public void OpenVault()
            { 
                if (State != LockState.Locked && State != LockState.Open)
                {
                    State = LockState.Open;
                }
                else
                    Console.WriteLine("Action not allowed");
            }
            public void CloseVault()
            {
                if (State != LockState.Closed && State != LockState.Locked)
                {
                    State = LockState.Closed;
                }
                else
                    Console.WriteLine("Action not allowed");
            }
            public void UnlockVault()
            {
                if (State != LockState.Closed && State != LockState.Open)
                {
                    State = LockState.Closed;
                }
                else
                    Console.WriteLine("Action not allowed");
            }
            
        }

        static void Main(string[] args)
        {
            Vault vault = new Vault(LockState.Closed);

            while (true)
            {
                Console.WriteLine("The vault is {0}. What do you want to do? ",vault.State);
                if (vault.State == LockState.Open) 
                    Console.WriteLine("\x1b[1mClose\x1b[0m");
                if (vault.State == LockState.Closed) 
                    Console.WriteLine("\x1b[1mOpen\x1b[0m or \x1b[1mlock");
                if (vault.State == LockState.Locked) 
                    Console.WriteLine("\x1b[1mUnlock\x1b[0m");

                string s = Console.ReadLine().ToUpper();

                switch (s)
                {
                    case "OPEN":
                        Console.Clear();
                        vault.OpenVault();
                        break;
                    case "CLOSE":
                        Console.Clear();
                        vault.CloseVault();
                        break;
                    case "LOCK":
                        Console.Clear();
                        vault.LockVault();
                        break;
                    case "UNLOCK":
                        Console.Clear();
                        vault.UnlockVault();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Incorrect action");
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}