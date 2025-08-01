using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjIndexesIceTask
{
    public class CarService
    {
        int serviceInterval;
        string carName, tyreSize, colour, typeOfService;

        public CarService(int serviceInterval, string carName, string tyreSize, string colour, string typeOfService)
        {
            this.serviceInterval = serviceInterval;
            this.carName = carName;
            this.tyreSize = tyreSize;
            this.colour = colour;
            this.typeOfService = typeOfService;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.serviceInterval;
                else if (index == 1)
                    return this.carName;
                else if (index == 2)
                    return this.tyreSize;
                else if (index == 3)
                    return this.colour;
                else if (index == 4)
                    return this.typeOfService;
                return null;
            }

            set
            {
                if (index == 0)
                    this.serviceInterval = (int)value;
                else if (index == 1)
                    this.carName = (string)value;
                else if (index == 2)
                    this.tyreSize = (string)value;
                else if (index == 3)
                    this.colour = (string)value;
                else if (index == 4)
                    this.typeOfService = (string)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName == "interval")
                    return this.serviceInterval;
                else if (attrName == "carname")
                    return this.carName;
                else if (attrName == "tyresize")
                    return this.tyreSize;
                else if (attrName == "Colour")
                    return this.colour;
                else if (attrName == "typeofservice")
                    return this.typeOfService;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("interval"))
                    this.serviceInterval = (int)value;
                else if (attrName.ToLower().Equals("carname"))
                    this.carName = (string)value;
                else if (attrName.ToLower().Equals("tyresize"))
                    this.tyreSize = (string)value;
                else if (attrName.ToLower().Equals("Colour"))
                    this.colour = (string)value;
                else if (attrName.ToLower().Equals("typeofservice"))
                    this.typeOfService = (string)value;

            }
        }
    }
}
