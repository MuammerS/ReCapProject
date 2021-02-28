using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message) //Bana bir Data ver ve birde mesaj ver ama base de ki  bu işklemin sonucu
                                                                                     //atadır işlem sonucu True dur  ve mesajıdır der
        {

        }

        public ErrorDataResult(T data) : base(data, false) //Mesaj göndermeden data gönder ve true gonder
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)//Burdada datayı yani T yi Default Aldık
        {

        }

        public ErrorDataResult() : base(default, false)//sadece true döndürüyor ve default data oluyor 
        {

        }
    }
}
