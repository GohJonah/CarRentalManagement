using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly String MakesEndpoint = $"{Prefix}/makes";
        public static readonly String ModelsEndpoint = $"{Prefix}/models";
        public static readonly String ColoursEndpoint = $"{Prefix}/colours";
        public static readonly String VehiclesEndpoint = $"{Prefix}/vehicles";
        public static readonly String BookingsEndpoint = $"{Prefix}/bookings";
        public static readonly String CustomersEndpoint = $"{Prefix}/customers";
    }
}
