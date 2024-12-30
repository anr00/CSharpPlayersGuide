using IField;
using McDroid;

using pig = McDroid.Pig;

Sheep s1 = new Sheep();
pig p1 = new pig();
IField.Pig p2 = new IField.Pig();

namespace IField
{
    public class Sheep {}
    public class Pig {}
}

namespace McDroid
{
    public class Cow {}
    public class Pig {}
}