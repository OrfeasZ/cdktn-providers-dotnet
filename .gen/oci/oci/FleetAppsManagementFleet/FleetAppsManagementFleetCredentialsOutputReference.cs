using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleet
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementFleet.FleetAppsManagementFleetCredentialsOutputReference), fullyQualifiedName: "oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FleetAppsManagementFleetCredentialsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public FleetAppsManagementFleetCredentialsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementFleetCredentialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementFleetCredentialsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEntitySpecifics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsEntitySpecifics\"}}]")]
        public virtual void PutEntitySpecifics(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsEntitySpecifics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsEntitySpecifics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPassword", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsPassword\"}}]")]
        public virtual void PutPassword(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsPassword @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsPassword)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsUser\"}}]")]
        public virtual void PutUser(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsUser)}, new object[]{@value});
        }

        [JsiiProperty(name: "entitySpecifics", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsEntitySpecificsOutputReference\"}")]
        public virtual oci.FleetAppsManagementFleet.FleetAppsManagementFleetCredentialsEntitySpecificsOutputReference EntitySpecifics
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.FleetAppsManagementFleetCredentialsEntitySpecificsOutputReference>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsPasswordOutputReference\"}")]
        public virtual oci.FleetAppsManagementFleet.FleetAppsManagementFleetCredentialsPasswordOutputReference Password
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.FleetAppsManagementFleetCredentialsPasswordOutputReference>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsUserOutputReference\"}")]
        public virtual oci.FleetAppsManagementFleet.FleetAppsManagementFleetCredentialsUserOutputReference User
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.FleetAppsManagementFleetCredentialsUserOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "entitySpecificsInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsEntitySpecifics\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsEntitySpecifics? EntitySpecificsInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsEntitySpecifics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsPassword\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsPassword? PasswordInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsPassword?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentialsUser\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsUser? UserInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentialsUser?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.fleetAppsManagementFleet.FleetAppsManagementFleetCredentials\"}]}}", isOptional: true)]
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
                        case oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentials cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementFleet.IFleetAppsManagementFleetCredentials).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
