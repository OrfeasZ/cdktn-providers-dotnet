using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionOutputReference), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedDevopsPoolAzureDevopsOrganizationPermissionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedDevopsPoolAzureDevopsOrganizationPermissionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedDevopsPoolAzureDevopsOrganizationPermissionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDevopsPoolAzureDevopsOrganizationPermissionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdministratorAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount\"}}]")]
        public virtual void PutAdministratorAccount(azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdministratorAccount")]
        public virtual void ResetAdministratorAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "administratorAccount", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccountOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccountOutputReference AdministratorAccount
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccountOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "administratorAccountInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount? AdministratorAccountInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermission\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission?>();
            set => SetInstanceProperty(value);
        }
    }
}
