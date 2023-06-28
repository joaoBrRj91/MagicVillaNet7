using System;
namespace MagicVilla.API.Models.Response.Interface
{
	public interface IResponse
	{
        public List<string> ErrorMessages { get; set; }

        public object Result { get; set; }
    }
}

