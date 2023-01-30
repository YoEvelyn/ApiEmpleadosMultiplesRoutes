using ApiEmpleadosMultiplesRoutes.Data;
using ApiEmpleadosMultiplesRoutes.Models;

namespace ApiEmpleadosMultiplesRoutes.Repositories
{
    public class RepositoryEmpleados
    {
        private EmpleadosContext context;
        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;


        }
        public List<Empleado> GetEmpleados()
        {
            var consulta = from datos in this.context.Empleados
                           select datos;
            return consulta.ToList();
        }

        public Empleado FindEmpleado(int id)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.IdEmpleado == id
                           select datos;
            return consulta.FirstOrDefault();
        }
    }
}


