using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserOutputReference), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putManager", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserManager\"}}]")]
        public virtual void PutManager(oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserManager @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserManager)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCostCenter")]
        public virtual void ResetCostCenter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDepartment")]
        public virtual void ResetDepartment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDivision")]
        public virtual void ResetDivision()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmployeeNumber")]
        public virtual void ResetEmployeeNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManager")]
        public virtual void ResetManager()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrganization")]
        public virtual void ResetOrganization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "manager", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserManagerOutputReference\"}")]
        public virtual oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserManagerOutputReference Manager
        {
            get => GetInstanceProperty<oci.IdentityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserManagerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCenterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CostCenterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "departmentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DepartmentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "divisionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DivisionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "employeeNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmployeeNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managerInput", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserManager\"}", isOptional: true)]
        public virtual oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserManager? ManagerInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20UserManager?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "organizationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrganizationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "costCenter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostCenter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "department", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Department
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "division", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Division
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "employeeNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmployeeNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Organization
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User\"}", isOptional: true)]
        public virtual oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasextensionenterprise20User?>();
            set => SetInstanceProperty(value);
        }
    }
}
