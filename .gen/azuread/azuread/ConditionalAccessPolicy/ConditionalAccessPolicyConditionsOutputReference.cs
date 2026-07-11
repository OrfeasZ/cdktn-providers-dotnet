using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiClass(nativeType: typeof(azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsOutputReference), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConditionalAccessPolicyConditionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConditionalAccessPolicyConditionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ConditionalAccessPolicyConditionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConditionalAccessPolicyConditionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplications\"}}]")]
        public virtual void PutApplications(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientApplications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplications\"}}]")]
        public virtual void PutClientApplications(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDevices", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevices\"}}]")]
        public virtual void PutDevices(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevices @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevices)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsLocations\"}}]")]
        public virtual void PutLocations(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsLocations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsLocations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlatforms", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsPlatforms\"}}]")]
        public virtual void PutPlatforms(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsPlatforms @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsPlatforms)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsers", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsers\"}}]")]
        public virtual void PutUsers(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsers @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsers)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthenticationFlowTransferMethods")]
        public virtual void ResetAuthenticationFlowTransferMethods()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientApplications")]
        public virtual void ResetClientApplications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDevices")]
        public virtual void ResetDevices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInsiderRiskLevels")]
        public virtual void ResetInsiderRiskLevels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocations")]
        public virtual void ResetLocations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatforms")]
        public virtual void ResetPlatforms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServicePrincipalRiskLevels")]
        public virtual void ResetServicePrincipalRiskLevels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSignInRiskLevels")]
        public virtual void ResetSignInRiskLevels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserRiskLevels")]
        public virtual void ResetUserRiskLevels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "applications", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsOutputReference\"}")]
        public virtual azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsOutputReference Applications
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsOutputReference>()!;
        }

        [JsiiProperty(name: "clientApplications", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplicationsOutputReference\"}")]
        public virtual azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplicationsOutputReference ClientApplications
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplicationsOutputReference>()!;
        }

        [JsiiProperty(name: "devices", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesOutputReference\"}")]
        public virtual azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesOutputReference Devices
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesOutputReference>()!;
        }

        [JsiiProperty(name: "locations", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsLocationsOutputReference\"}")]
        public virtual azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsLocationsOutputReference Locations
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsLocationsOutputReference>()!;
        }

        [JsiiProperty(name: "platforms", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsPlatformsOutputReference\"}")]
        public virtual azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsPlatformsOutputReference Platforms
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsPlatformsOutputReference>()!;
        }

        [JsiiProperty(name: "users", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersOutputReference\"}")]
        public virtual azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersOutputReference Users
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationsInput", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplications\"}", isOptional: true)]
        public virtual azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications? ApplicationsInput
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationFlowTransferMethodsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AuthenticationFlowTransferMethodsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientApplicationsInput", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplications\"}", isOptional: true)]
        public virtual azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplications? ClientApplicationsInput
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientAppTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ClientAppTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devicesInput", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevices\"}", isOptional: true)]
        public virtual azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevices? DevicesInput
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevices?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "insiderRiskLevelsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InsiderRiskLevelsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationsInput", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsLocations\"}", isOptional: true)]
        public virtual azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsLocations? LocationsInput
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsLocations?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformsInput", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsPlatforms\"}", isOptional: true)]
        public virtual azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsPlatforms? PlatformsInput
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsPlatforms?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicePrincipalRiskLevelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ServicePrincipalRiskLevelsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signInRiskLevelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SignInRiskLevelsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userRiskLevelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? UserRiskLevelsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usersInput", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsers\"}", isOptional: true)]
        public virtual azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsers? UsersInput
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsers?>();
        }

        [JsiiProperty(name: "authenticationFlowTransferMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AuthenticationFlowTransferMethods
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientAppTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ClientAppTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "insiderRiskLevels", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InsiderRiskLevels
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "servicePrincipalRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ServicePrincipalRiskLevels
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "signInRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SignInRiskLevels
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UserRiskLevels
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditions\"}", isOptional: true)]
        public virtual azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditions? InternalValue
        {
            get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditions?>();
            set => SetInstanceProperty(value);
        }
    }
}
