namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class UserParentship
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int ChildId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescr { get; set; }

        public IsusUser Child { get; set; }
        public IsusUser Parent { get; set; }
    }
}
