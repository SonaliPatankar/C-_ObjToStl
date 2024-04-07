# TRNSLATOR:
This project aims to optimize the Triangulation data structure and provide functionalities as follow:
1. convert .stl file to .obj file
2. convert .obj file to .stl file
 
# File Structure
 
## Point3D.cpp: Defines a 3D point class with x, y, and z coordinates. 
Point3D(double x, double y, double z): Constructor for Point3D.
~Point3D(): Destructor for Point3D.
double x() const: Returns the x-coordinate of the point.
double y() const: Returns the y-coordinate of the point.
double z() const: Returns the z-coordinate of the point.
 
## Triangle.cpp: Represents a 3D triangle using three indices
Triangle(int v1, int v2, int v3);Constructor for Triangle
~Triangle();Destructor for Triangle
const int v1() const; return first index
const int v2() const; return second index
const int v3() const; return third index
 
## Triangulation.cpp: Manages a collection of triangles forming a 3D mesh.
 
Triangulation(): Constructor for Triangulation.
~Triangulation(): Destructor for Triangulation.
std::vector<Triangle> getTriangles() : Returns the collection of triangles.
 
## OBJReader.cpp: Read .obj file
 
void readOBJ(std::string &filePath,Triangulation &triangulation): Reads an OBJ file and populate triangulation object
 
## STLReader.cpp : Read .stl file
 
void readSTL(std::string &filePath, Triangulation &triangulation):Function to read data from an STL file and populate a Triangulation object
  
## ObjConvertor.h/cpp : Convert .obj file into .stl file
 
void objToStlConversion(std::string &filePath,Triangulation &triangulation): Function to convert OBJ file to STL format
 
## StlConvertor.cpp : Manage conversion of .stl file to .obj file
 
void stlToObjConversion(std::string &filePath, Triangulation &triangulation): Function to convert STL file to OBJ format
 
## inputfiles:
Store .stl and .obj file
 
## outputfiles: 
Store .txt, ,obj and .stl files
