using System.Reflection.Metadata;

namespace Workshop_C;

public class GeometricOperation
{
    // 1. Calculate the area of a circle given its radius
    public double CalculateCircleArea(double radius)
    {
        if (radius < 0)
        {
            return 0;
        }
        double r = radius * radius;
        double c = Math.PI * r;
        double resultadoRedondeado = Math.Round(c, 2, MidpointRounding.AwayFromZero);

        return resultadoRedondeado;
    }

    // 2. Calculate the circumference of a circle given its radius
    public double CalculateCircleCircumference(double radius)
    {
        return 2 * Math.PI * radius;
    }

    // 3. Calculate the area of a rectangle given its width and height
    public double CalculateRectangleArea(double width, double height)
    {

        return width * height;
    }

    // 4. Calculate the perimeter of a rectangle given its width and height
    public double CalculateRectanglePerimeter(double width, double height)
    {

        return 2 * (width + height);
    }

    // 5. Calculate the area of a triangle given its base and height
    public double CalculateTriangleArea(double baseLength, double height)
    {
        // TODO: Implement
        return (baseLength * height) / 2;
    }

    // 6. Calculate the perimeter of a triangle given its three sides
    public double CalculateTrianglePerimeter(double side1, double side2, double side3)
    {
        // TODO: Implement
        return side1 + side2 + side3;
    }

    // 7. Calculate the area of a square given its side length
    public double CalculateSquareArea(double side)
    {
        // TODO: Implement
        return side * side;
    }

    // 8. Calculate the perimeter of a square given its side length
    public double CalculateSquarePerimeter(double side)
    {
        return side * 4;
        // TODO: Implement
    }

    // 9. Calculate the length of the hypotenuse of a right triangle given the other two sides
    public double CalculateHypotenuse(double sideA, double sideB)
    {
        // TODO: Implement
        if (sideA == 0)
        {
            return 0;
        }
        if (sideB == 0)
        {
            return 0;
        }
        return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
    }

    // 10. Calculate the area of a trapezoid given its bases and height
    public double CalculateTrapezoidArea(double base1, double base2, double height)
    {
        // TODO: Implement
        return ((base1 + base2) / 2) * height;
    }

    // 11. Calculate the volume of a cylinder given its radius and height
    public double CalculateCylinderVolume(double radius, double height)
    {
        // TODO: Implement
        return Math.PI * Math.Pow(radius, 2) * height;
    }

    // 12. Calculate the volume of a cube given its side length
    public double CalculateCubeVolume(double side)
    {
        // TODO: Implement
        return Math.Pow(side, 3);
    }

    // 13. Calculate the volume of a sphere given its radius
    public double CalculateSphereVolume(double radius)
    {
        if (radius == 0)
        {
            return 0;
        }
        // TODO: Implement
        return ((4 * Math.PI * Math.Pow(radius, 3)) / 3);
    }

    // 14. Calculate the surface area of a cylinder given its radius and height
    public double CalculateCylinderSurfaceArea(double radius, double height)
    {
        // TODO: Implement
        return 2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius, 2);
    }

    // 15. Calculate the surface area of a cube given its side length
    public double CalculateCubeSurfaceArea(double side)
    {
        // TODO: Implement
        return 6 * Math.Pow(side, 2);
    }

    // 16. Calculate the surface area of a sphere given its radius
    public double CalculateSphereSurfaceArea(double radius)
    {
        // TODO: Implement
        return 4 * Math.PI * Math.Pow(radius, 2);
    }

    // 17. Calculate the volume of a cone given its radius and height
    public double CalculateConeVolume(double radius, double height)
    {
        double v = (Math.PI * Math.Pow(radius, 2) * height) / 3;
        double resultadoRedondeado = Math.Round(v, 1, MidpointRounding.AwayFromZero);
        return resultadoRedondeado;
    }

    // 18. Calculate the volume of a pyramid given its base and height
    public double CalculatePyramidVolume(double baseArea, double height)
    {
        // TODO: Implement
        return (baseArea * height) / 3;
    }

    // 19. Calculate the area of a regular polygon given its number of sides and side length
    public double CalculateRegularPolygonArea(int numSides, double sideLength)
    {
        if (numSides < 3)
        {
            return 0;
        }

        double apotema = sideLength / (2 * Math.Tan(Math.PI / numSides)); // Calcular la apotema del polígono
        double perimeter = numSides * sideLength; // Calcular el perímetro del polígono
        double area = 0.5 * apotema * perimeter; // Calcular el área del polígono
        double r = Math.Round(area, 1, MidpointRounding.AwayFromZero);

        return r;
    }

    // 20. Calculate the perimeter of a regular polygon given its number of sides and side length
    public double CalculateRegularPolygonPerimeter(int numSides, double sideLength)
    {
        double perimetro = numSides * sideLength;
        return perimetro;
    }

    // 21. Check if three sides can form a triangle
    public bool CanFormTriangle(double side1, double side2, double side3)
    {
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 22. Calculate the area of a parallelogram given its base and height
    public double CalculateParallelogramArea(double baseLength, double height)
    {
        double area = baseLength * height;
        return area;
    }

    // 23. Calculate the perimeter of a parallelogram given its base and sides
    public double CalculateParallelogramPerimeter(double baseLength, double sideLength)
    {
        double perimetro = 2 * (baseLength + sideLength);
        return perimetro;
    }

    // 24. Check if four sides can form a rectangle
    public bool CanFormRectangle(double side1, double side2, double side3, double side4)
    {
        if ((side1 == side2 && side3 == side4) || (side1 == side3 && side2 == side4) || (side1 == side4 && side2 == side3))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 25. Calculate the diagonal of a rectangle given its width and height
    public double CalculateRectangleDiagonal(double width, double height)
    {
        double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
        return diagonal;
    }

    // 26. Check if a set of points form a right triangle
    public bool IsRightTriangle(double sideA, double sideB, double hypotenuse)
    {
        if (Math.Pow(hypotenuse, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 27. Calculate the area of an ellipse given its major and minor axes
    public double CalculateEllipseArea(double majorAxis, double minorAxis)
    {
        return Math.PI * majorAxis * minorAxis;
    }

    // 28. Check if three angles can form a triangle (sum of angles must be 180 degrees)
    public bool CanFormTriangleFromAngles(double angle1, double angle2, double angle3)
    {
        if (angle1 == 0)
        {
            return false;
        }
        if (angle1 + angle2 + angle3 == 180)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 29. Calculate the surface area of a cone given its radius and slant height
    public double CalculateConeSurfaceArea(double radius, double slantHeight)
    {
        return Math.PI * radius * (radius + slantHeight);
    }

    // 30. Calculate the perimeter of an ellipse given its major and minor axes
    public double CalculateEllipsePerimeter(double majorAxis, double minorAxis)
    {
        if (majorAxis == 0)
        {
            return 0;
        }
        if (minorAxis == 0)
        {
            return 0;
        }
        double h = Math.Pow((majorAxis - minorAxis), 2) / Math.Pow((majorAxis + minorAxis), 2);
        double perimeter = Math.PI * (majorAxis + minorAxis) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        double r = Math.Round(perimeter, MidpointRounding.AwayFromZero);

        return r;
    }

    // 31. Use the Law of Cosines to find the third side given two sides and the included angle
    public double CalculateThirdSideLawOfCosines(double sideA, double sideB, double angleDegrees)
    {
        if (angleDegrees == 0)
        {
            return 0;
        }
        if (sideA == 0)
        {
            return 0;
        }
        if (sideB == 0)
        {
            return 0;
        }
        double angulo = Math.PI * angleDegrees / 180.0; // Convert angle to radians
        double sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * Math.Cos(angulo));
        double r = Math.Round(sideC, 2, MidpointRounding.ToZero);
        return r;
    }

    // 32. Use the Law of Cosines to find an angle given three sides of a triangle
    public double CalculateAngleLawOfCosines(double sideA, double sideB, double sideC)
    {
        double cosAngleA = (Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - Math.Pow(sideA, 2)) / (2 * sideB * sideC);
        double angleA = Math.Acos(cosAngleA); 
        double r = Math.Round(angleA, 2, MidpointRounding.AwayFromZero);

        return angleA;

    }

    // 33. Use the Law of Sines to find a side given an angle and its opposite side
    public double CalculateSideLawOfSines(double angleA, double sideA, double angleB)
    {
        if (sideA == 0)
        {
            return 0;
        }
        double sideB = (sideA * Math.Sin(Math.PI * angleB / 180)) / Math.Sin(Math.PI * angleA / 180);
        return sideB;

    }

    // 34. Use the Law of Sines to find an angle given two angles and one side
    public double CalculateAngleLawOfSines(double angleA, double angleB, double sideC)
    {
        if (sideC == 0)
        {
            return 0;
        }
        double sideA = sideC * Math.Sin(Math.PI * angleA / 180);
        double angleC = Math.Asin((sideA / sideC) * Math.Sin(Math.PI * angleB / 180)) * (180.0 / Math.PI);
        double r = Math.Round(angleC, 1, MidpointRounding.AwayFromZero);
        return r;
    }

    // 35. Find the area of a triangle given two sides and the included angle using the Law of Cosines
    public double CalculateTriangleAreaWithCosine(double sideA, double sideB, double angleDegrees)
    {
        double area = 0.5 * sideA * sideB * Math.Sin(Math.PI * angleDegrees / 180);
        return area;
    }

    // 36. Check if three sides can form a triangle using the Law of Cosines
    public bool CanFormTriangleWithCosines(double sideA, double sideB, double sideC)
    {
        if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 37. Calculate the perimeter of a triangle using the Law of Cosines
    public double CalculateTrianglePerimeterWithCosines(double sideA, double sideB, double sideC)
    {
        if (sideA == 0)
        {
            return 0;
        }
        if (sideB == 0)
        {
            return 0;
        }
        if (sidec == 0)
        {
            return 0;

        }
        double perimeter = sideA + sideB + sideC;

        return perimeter;
    }

    // 38. Calculate the height of a triangle using the Law of Cosines
    public double CalculateTriangleHeightWithCosines(double sideA, double angleDegrees)
    {
        double altura = sideA * Math.Sin(Math.PI * angleDegrees / 180);
        return altura;
    }

    // 39. Check if an angle is a right angle using the Law of Cosines
    public bool IsRightAngleWithCosines(double sideA, double sideB, double sideC)
    {
        double cosAngle = (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - Math.Pow(sideC, 2)) / (2 * sideA * sideB);

        // Si el coseno del ángulo es cero, entonces es un ángulo recto
        if (Math.Abs(cosAngle) < 0.000001)  // Usamos una pequeña tolerancia para evitar errores de precisión
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 40. Calculate the area of a triangle given two sides and the included angle using the Law of Sines
    public double CalculateTriangleAreaWithSines(double angleA, double sideA, double sideB)
    {
        double area = 0.5 * sideA * sideB * Math.Sin(Math.PI * angleA / 180);
        double r = Math.Round(area, 2, MidpointRounding.ToZero);
        return r;
    }
}