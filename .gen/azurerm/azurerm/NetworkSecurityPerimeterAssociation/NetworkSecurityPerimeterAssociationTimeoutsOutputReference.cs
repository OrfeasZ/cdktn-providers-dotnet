using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkSecurityPerimeterAssociation
{
    [JsiiClass(nativeType: typeof(azurerm.NetworkSecurityPerimeterAssociation.NetworkSecurityPerimeterAssociationTimeoutsOutputReference), fullyQualifiedName: "azurerm.networkSecurityPerimeterAssociation.NetworkSecurityPerimeterAssociationTimeoutsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkSecurityPerimeterAssociationTimeoutsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkSecurityPerimeterAssociationTimeoutsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkSecurityPerimeterAssociationTimeoutsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkSecurityPerimeterAssociationTimeoutsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCreate")]
        public virtual void ResetCreate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDelete")]
        public virtual void ResetDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRead")]
        public virtual void ResetRead()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdate")]
        public virtual void ResetUpdate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "createInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeleteInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReadInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpdateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Create
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Delete
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Read
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Update
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.NetworkSecurityPerimeterAssociation.INetworkSecurityPerimeterAssociationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.networkSecurityPerimeterAssociation.NetworkSecurityPerimeterAssociationTimeouts\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.NetworkSecurityPerimeterAssociation.INetworkSecurityPerimeterAssociationTimeouts cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NetworkSecurityPerimeterAssociation.INetworkSecurityPerimeterAssociationTimeouts).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
