using SampleCSharp.Api.Commands;
using System.Collections.Generic;

namespace SampleCSharp.Api.Repositorios
{
    public static class SampleCSharpRepositorio
    {
        public static List<SampleCommand> Data = new List<SampleCommand> {
            new SampleCommand { Id = 1,  Color = "Yellow", Shape = "Square" },
            new SampleCommand { Id = 2,  Color = "Red", Shape = "Circle" },
            new SampleCommand { Id = 3,  Color = "Green", Shape = "Rectangle" },
            new SampleCommand { Id = 4,  Color = "Blue", Shape = "Triangle" }
        };
    }
}
