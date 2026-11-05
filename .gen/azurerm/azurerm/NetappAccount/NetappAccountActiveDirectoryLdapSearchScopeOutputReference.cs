using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappAccount
{
    [JsiiClass(nativeType: typeof(azurerm.NetappAccount.NetappAccountActiveDirectoryLdapSearchScopeOutputReference), fullyQualifiedName: "azurerm.netappAccount.NetappAccountActiveDirectoryLdapSearchScopeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetappAccountActiveDirectoryLdapSearchScopeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetappAccountActiveDirectoryLdapSearchScopeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetappAccountActiveDirectoryLdapSearchScopeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappAccountActiveDirectoryLdapSearchScopeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGroupDn")]
        public virtual void ResetGroupDn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupMembershipFilter")]
        public virtual void ResetGroupMembershipFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserDn")]
        public virtual void ResetUserDn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupDnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupDnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupMembershipFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupMembershipFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserDnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "groupDn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupDn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupMembershipFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupMembershipFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userDn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserDn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.netappAccount.NetappAccountActiveDirectoryLdapSearchScope\"}", isOptional: true)]
        public virtual azurerm.NetappAccount.INetappAccountActiveDirectoryLdapSearchScope? InternalValue
        {
            get => GetInstanceProperty<azurerm.NetappAccount.INetappAccountActiveDirectoryLdapSearchScope?>();
            set => SetInstanceProperty(value);
        }
    }
}
