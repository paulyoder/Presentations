namespace RIAExample3
{
    using System.Windows.Controls;
    using System.Windows.Navigation;
using RIAExample3.Web;
    using System.Linq;
    /// <summary>
    /// Home page for the application.
    /// </summary>
    public partial class Home : Page
    {
        EmployeeDomainContext _context;
        /// <summary>
        /// Creates a new <see cref="Home"/> instance.
        /// </summary>
        public Home()
        {
            InitializeComponent();

            this.Title = ApplicationStrings.HomePageTitle;
            _context = new EmployeeDomainContext();
            dataGrid.ItemsSource = _context.Employees;
            _context.Load(_context.GetAllEmployeesQuery());
				
        }

        /// <summary>
        /// Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }


        private void AddEmployeeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _context.Employees.Add(new Employee()
            {
                Id = _context.Employees.Count + 1,
                FirstName = "Ben",
                LastName = "Franklin"
            });
            _context.SubmitChanges();
        }

        private void UpdateEmployeeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _context.Employees.Last().FirstName = "Billy";
            _context.SubmitChanges();
        }

        private void DeleteEmployeeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _context.Employees.Remove(_context.Employees.Last());
            _context.SubmitChanges();
        }
				
    }
}