namespace CustomConstraints.Constraints
{
    public class WookieeLanguageConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if(values.TryGetValue(routeKey, out var value))
            {
                var content = Convert.ToString(value);

                return !string.IsNullOrEmpty(content) && content.StartsWith("wookie");
            }

            return false;
        }
    }
}
