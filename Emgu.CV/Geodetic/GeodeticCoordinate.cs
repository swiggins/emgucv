﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Emgu.CV.Geodetic
{
   /// <summary>
   /// A geodetic coordinate that is defined by its latitude, longitude and altitude
   /// </summary>
   public struct GeodeticCoordinate : IEquatable<GeodeticCoordinate>
   {
      private double _latitude;
      private double _longitude;
      private double _altitude;

      /// <summary>
      /// Indicates the origin of the Geodetic Coordinate
      /// </summary>
      public static readonly GeodeticCoordinate Empty = new GeodeticCoordinate();

      /// <summary>
      /// Create a geodetic coordinate using the specific values
      /// </summary>
      /// <param name="latitude">Latitude</param>
      /// <param name="longitude">Longitude</param>
      /// <param name="altitude">Altitude</param>
      public GeodeticCoordinate(double latitude, double longitude, double altitude)
      {
         _latitude = latitude;
         _longitude = longitude;
         _altitude = altitude;
      }

      /// <summary>
      /// Latitude (phi)
      /// </summary>
      public double Latitude
      {
         get
         {
            return _latitude;
         }
         set
         {
            _latitude = value;
         }
      }

      /// <summary>
      /// Longitude (lambda)
      /// </summary>
      public double Longitude
      {
         get
         {
            return _longitude;
         }
         set
         {
            _longitude = value;
         }
      }

      /// <summary>
      /// Altitude (height)
      /// </summary>
      public double Altitude
      {
         get
         {
            return _altitude;
         }
         set
         {
            _altitude = value;
         }
      }

      /// <summary>
      /// Compute the sum of two GeodeticCoordinates
      /// </summary>
      /// <param name="coor1">The first coordinate to be added</param>
      /// <param name="coor2">The second coordinate to be added</param>
      /// <returns>The sum of two GeodeticCoordinates</returns>
      public static GeodeticCoordinate operator +(GeodeticCoordinate coor1, GeodeticCoordinate coor2)
      {
         return new GeodeticCoordinate(
            coor1.Latitude + coor2.Latitude,
            coor1.Longitude + coor2.Longitude,
            coor1.Altitude + coor2.Altitude);
      }

      /// <summary>
      /// Compute <paramref name="coor1"/> - <paramref name="coor2"/>
      /// </summary>
      /// <param name="coor1">The first coordinate</param>
      /// <param name="coor2">The coordinate to be substracted</param>
      /// <returns><paramref name="coor1"/> - <paramref name="coor2"/></returns>
      public static GeodeticCoordinate operator -(GeodeticCoordinate coor1, GeodeticCoordinate coor2)
      {
         return new GeodeticCoordinate(
            coor1.Latitude - coor2.Latitude,
            coor1.Longitude - coor2.Longitude,
            coor1.Altitude - coor2.Altitude);
      }

      #region IEquatable<GeodeticCoordinate> Members
      /// <summary>
      /// Check if this Geodetic coordinate equals <paramref name="other"/>
      /// </summary>
      /// <param name="other"></param>
      /// <returns></returns>
      public bool Equals(GeodeticCoordinate other)
      {
         return
            Latitude == other.Latitude
            && Longitude == other.Longitude
            && Altitude == other.Altitude;
      }

      #endregion
   }
}
