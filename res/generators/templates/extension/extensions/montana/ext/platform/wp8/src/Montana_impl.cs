using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using rhoruntime;

namespace rho {

namespace <%= name.camel_case() %>Impl
{
    public class <%= name.camel_case() %> : I<%= name.camel_case() %>Impl
    {
        public <%= name.camel_case() %>()
        {
            var _runtime = new <%= name.camel_case() %>RuntimeComponent(this);
        }

        public void enable(IReadOnlyDictionary<string, string> propertyMap, I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }

        public void start(I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }

        public void stop(I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }

        public void disable(I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }

        public void take(IReadOnlyDictionary<string, string> propertyMap, I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getProperty(string propertyName, I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getProperties(IReadOnlyList<string> arrayofNames, I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }

        public void getAllProperties(I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setProperty(string propertyName, string propertyValue, I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }

        public void setProperties(IReadOnlyDictionary<string, string> propertyMap, I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }

        public void clearAllProperties(I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }
    }

    public class <%= name.camel_case() %>Singleton : I<%= name.camel_case() %>SingletonImpl
    {
        public <%= name.camel_case() %>Singleton()
        {
            var _runtime = new <%= name.camel_case() %>SingletonComponent(this);
        }

        public void enumerate(I<%= name.camel_case() %>MethodResult oResult)
        {
            // implement this method in C# here
        }
    }
}

}