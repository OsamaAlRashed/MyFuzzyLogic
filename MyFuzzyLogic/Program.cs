Console.WriteLine("Enter social rate:");
double social = Double.Parse(Console.ReadLine());

Console.WriteLine("Enter health rate:");
double health = Double.Parse(Console.ReadLine());

double rule1 = Math.Min(Social(social), Health(health)); //Accepted
double rule2 = Math.Min(NonSocial(social), NonHealth(health)); //Denied

double y1 = Accepted(rule1, 0.4, 1);

double y2 = Denied(rule2, 0, 0.6);

y1 = y1 + 1 / 2;
y2 = y2 / 2;

double Ans;

if (rule1 + rule2 == 0)
{
    Ans = 0;
}
else
{
    Ans = (y1 * rule1 + y2 * rule2) / (rule1 + rule2);
}

Console.WriteLine("Ans is: ");
Console.WriteLine(Ans);

static double Social(double x)
{
    return Grade(x, 0.4, 1);
}
static double NonSocial(double x)
{
    return ReverseGrade(x, 0, 0.6);
}

static double Health(double x)
{
    return Grade(x, 0.4, 1);
}
static double NonHealth(double x)
{
    return ReverseGrade(x, 0, 0.6);
}

static double Grade(double x, double m_x0, double m_x1)
{
    if (x <= m_x0)
    {
        return 0;
    }
    else if (x < m_x1)
    {
        return (x - m_x0) / (m_x1 - m_x0);
    }
    else
    {
        return 1;
    }
}
static double ReverseGrade(double x, double m_x0, double m_x1)
{
    if (x <= m_x0)
    {
        return 1;
    }
    else if (x < m_x1)
    {
        return (m_x1 - x) / (m_x1 - m_x0);
    }
    else
    {
        return 0;
    }
}

static double Accepted(double y, double m_x0, double m_x1)
{
    return y * (m_x1 - m_x0) + m_x0;
}
static double Denied(double y, double m_x0, double m_x1)
{
    return m_x1 - y * (m_x1 - m_x0);
}