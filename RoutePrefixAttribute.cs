// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Mvc
{
    public class RoutePrefixAttribute : RouteAttribute
    {
        public RoutePrefixAttribute(string template)
            : base(template)
        {
        }
    }
}