using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Services
{
    public interface IDISample
    {
        int Id { get; }
    }

    public interface IDISampleTransient : IDISample
    {
    }

    public interface IDISampleScoped : IDISample
    {
    }

    public interface IDISampleSingleton : IDISample
    {
    }
    public class DISampleService : IDISampleTransient, IDISampleScoped, IDISampleSingleton
    {
        private static int _counter;
        private int _id;

        public DISampleService()
        {
            _id = ++_counter;
        }

        public int Id => _id;
    }
}
