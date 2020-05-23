using DevEducationApp.DTO;
using DevEducationApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationApp.AdapterModels
{
    public interface IModelAdapter
    {
        IModel Convert(IDto input);
    }
}
