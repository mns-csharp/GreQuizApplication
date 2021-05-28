using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplicationLibrary
{    
    public enum LearntTypeEnum 
    { 
        NotLearnt = 1, 
        Learnt = 2, 
        All = 0 
    }
    public enum LearnFormTypeEnum 
    {
        Random, 
        FlachCard
    }
    public enum OrderByTypeEnum 
    { 
        None, 
        GroupNo, 
        Name, 
        CorrectnessCount
    }
    public enum FormViewMode
    {
        Nothing,
        Add,
        Edit,
        Collection,
        Picker
    }
    public enum UnitTypeEnum
    {
        Gram,
        Litre
    }
    public enum ContentTypeEnum
    {
        Text=1,
        Photo=2
    }
    public enum AnswerTypeEnum
    {
        FillInTheBlanks=1,
        ColumnCompare=2,
        MultipleChoice=3
    }
    public enum QuantitativeProblemTypeEnum
    {
        Arithmetic=1,
        Algebra=2,
        Inequalities=3,
        AbsoluteValues=4,
        Functions=5,
        Formulas=6,
        Sequences=7,
        Fractions=8,
        Decimals=9,
        Percents=10,
        Divisibilty=11,
        Primes=12,
        Exponents=13,
        Roots=14,
        NumberProperties=15,
        ratesAndWork=16,
        ratio=17,
        Statistics=18,
        Probability=19,
        OverlappingSets=20,
        DataInterpretation=21,
        PolygonsAndRectangularSolids=22,
        CirclesAndSylinders=23,
        Triangles=24,
        CoordinateGeometry=25,
        MixedGeometry=26
    }
    public class UnitTypeEnumConverter
    {
        public static UnitTypeEnum ConvertToEnum(Type type, object obj)
        {
            String name = Enum.GetName(type, obj);

            Enum enumValue = (Enum)Enum.Parse(type, name, false);

            return (UnitTypeEnum)enumValue;
        }
    }    

    
}
