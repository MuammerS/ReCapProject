using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message) //Bana bir Data ver ve birde mesaj ver ama base de ki  bu işklemin sonucu
                                                                                     //atadır işlem sonucu True dur  ve mesajıdır der
        {

        }

        public SuccessDataResult(T data) : base(data, true) //Mesaj göndermeden data gönder ve true gonder
        {

        }

        public SuccessDataResult(string message) : base(default, true, message)//Burdada datayı yani T yi Default Aldık
        {

        }

        public SuccessDataResult() : base(default, true)//sadece true döndürüyor ve default data oluyor 
        {

        }
    }
}
