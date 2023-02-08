using System;

namespace demo
{
    internal class login
    {
        private register register;

        public login()
        {
        }

        public login(register register)
        {
            this.register = register;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        public static implicit operator login(mainform v)
        {
            throw new NotImplementedException();
        }
    }
}