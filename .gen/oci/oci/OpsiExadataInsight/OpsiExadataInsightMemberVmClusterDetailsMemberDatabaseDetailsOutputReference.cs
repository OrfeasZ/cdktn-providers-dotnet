using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiExadataInsight
{
    [JsiiClass(nativeType: typeof(oci.OpsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference), fullyQualifiedName: "oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectionCredentialDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetails\"}}]")]
        public virtual void PutConnectionCredentialDetails(oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConnectionDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetails\"}}]")]
        public virtual void PutConnectionDetails(oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCredentialDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetails\"}}]")]
        public virtual void PutCredentialDetails(oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionCredentialDetails")]
        public virtual void ResetConnectionCredentialDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionDetails")]
        public virtual void ResetConnectionDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentialDetails")]
        public virtual void ResetCredentialDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseId")]
        public virtual void ResetDatabaseId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseResourceType")]
        public virtual void ResetDatabaseResourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbmPrivateEndpointId")]
        public virtual void ResetDbmPrivateEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentType")]
        public virtual void ResetDeploymentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEntitySource")]
        public virtual void ResetEntitySource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagementAgentId")]
        public virtual void ResetManagementAgentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpsiPrivateEndpointId")]
        public virtual void ResetOpsiPrivateEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceName")]
        public virtual void ResetServiceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemTags")]
        public virtual void ResetSystemTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connectionCredentialDetails", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetailsOutputReference\"}")]
        public virtual oci.OpsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetailsOutputReference ConnectionCredentialDetails
        {
            get => GetInstanceProperty<oci.OpsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsOutputReference\"}")]
        public virtual oci.OpsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsOutputReference ConnectionDetails
        {
            get => GetInstanceProperty<oci.OpsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "credentialDetails", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetailsOutputReference\"}")]
        public virtual oci.OpsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetailsOutputReference CredentialDetails
        {
            get => GetInstanceProperty<oci.OpsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionCredentialDetailsInput", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetails\"}", isOptional: true)]
        public virtual oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetails? ConnectionCredentialDetailsInput
        {
            get => GetInstanceProperty<oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionDetailsInput", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetails\"}", isOptional: true)]
        public virtual oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetails? ConnectionDetailsInput
        {
            get => GetInstanceProperty<oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialDetailsInput", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetails\"}", isOptional: true)]
        public virtual oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetails? CredentialDetailsInput
        {
            get => GetInstanceProperty<oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseResourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseResourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbmPrivateEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbmPrivateEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "entitySourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EntitySourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managementAgentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagementAgentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opsiPrivateEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OpsiPrivateEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SystemTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseResourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbmPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbmPrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "entitySource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntitySource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "opsiPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpsiPrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SystemTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetails\"}]}}", isOptional: true)]
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
                        case oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetails cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetails).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
