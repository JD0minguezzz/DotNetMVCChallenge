﻿using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public class AsteroidInformation
    {

        public class RootObject
        {
            public Links links { get; set; }
            public int element_count { get; set; }
            public Dictionary<string, Asteroid[]> near_earth_objects { get; set; }
        }

        public class Links
        {
            public string next { get; set; }
            public string prev { get; set; }
            public string self { get; set; }
        }

        public class Asteroid
        {
            public string id { get; set; }
            public string name { get; set; }
            public float absolute_magnitude_h { get; set; }
            public Estimated_Diameter estimated_diameter { get; set; }
            public bool is_potentially_hazardous_asteroid { get; set; }
            public Close_Approach_Data[] close_approach_data { get; set; }
            public bool is_sentry_object { get; set; }
        }

        public class Estimated_Diameter
        {
            public Meters meters { get; set; }
        }

        public class Meters
        {
            public float estimated_diameter_min { get; set; }
            public float estimated_diameter_max { get; set; }
        }

        public class Close_Approach_Data
        {
            public string close_approach_date { get; set; }
            public long epoch_date_close_approach { get; set; }
            public Relative_Velocity relative_velocity { get; set; }
            public Miss_Distance miss_distance { get; set; }
            public string orbiting_body { get; set; }
        }

        public class Relative_Velocity
        {
            public string kilometers_per_second { get; set; }
            public string kilometers_per_hour { get; set; }
            public string miles_per_hour { get; set; }
        }

        public class Miss_Distance
        {
            public string astronomical { get; set; }
            public string lunar { get; set; }
            public string kilometers { get; set; }
            public string miles { get; set; }
        }
    }
}
