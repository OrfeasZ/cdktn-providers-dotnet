using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApprovalWorkflowAssignment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment oci_identity_domains_approval_workflow_assignment}.</summary>
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignment), fullyQualifiedName: "oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentConfig\"}}]")]
    public class IdentityDomainsApprovalWorkflowAssignment : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment oci_identity_domains_approval_workflow_assignment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IdentityDomainsApprovalWorkflowAssignment(Constructs.Construct scope, string id, oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsApprovalWorkflowAssignment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsApprovalWorkflowAssignment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IdentityDomainsApprovalWorkflowAssignment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IdentityDomainsApprovalWorkflowAssignment to import.</param>
        /// <param name="importFromId">The id of the existing IdentityDomainsApprovalWorkflowAssignment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IdentityDomainsApprovalWorkflowAssignment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IdentityDomainsApprovalWorkflowAssignment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_approval_workflow_assignment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IdentityDomainsApprovalWorkflowAssignment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IdentityDomainsApprovalWorkflowAssignment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApprovalWorkflow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow\"}}]")]
        public virtual void PutApprovalWorkflow(oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAssignedTo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentAssignedTo\"}}]")]
        public virtual void PutAssignedTo(oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentAssignedTo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentAssignedTo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttributes")]
        public virtual void ResetAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttributeSets")]
        public virtual void ResetAttributeSets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcid")]
        public virtual void ResetOcid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeSchemaVersion")]
        public virtual void ResetResourceTypeSchemaVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignment))!;

        [JsiiProperty(name: "approvalWorkflow", typeJson: "{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentApprovalWorkflowOutputReference\"}")]
        public virtual oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentApprovalWorkflowOutputReference ApprovalWorkflow
        {
            get => GetInstanceProperty<oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentApprovalWorkflowOutputReference>()!;
        }

        [JsiiProperty(name: "assignedTo", typeJson: "{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentAssignedToOutputReference\"}")]
        public virtual oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentAssignedToOutputReference AssignedTo
        {
            get => GetInstanceProperty<oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentAssignedToOutputReference>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentIdcsCreatedByList\"}")]
        public virtual oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentIdcsLastModifiedByList\"}")]
        public virtual oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentMetaList\"}")]
        public virtual oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentMetaList Meta
        {
            get => GetInstanceProperty<oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentMetaList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentTagsList\"}")]
        public virtual oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentTagsList Tags
        {
            get => GetInstanceProperty<oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentTimeoutsOutputReference\"}")]
        public virtual oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IdentityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "approvalWorkflowInput", typeJson: "{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow? ApprovalWorkflowInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentApprovalWorkflow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assignedToInput", typeJson: "{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentAssignedTo\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentAssignedTo? AssignedToInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApprovalWorkflowAssignment.IIdentityDomainsApprovalWorkflowAssignmentAssignedTo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assignmentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssignmentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeSetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AttributeSetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OcidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemasInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SchemasInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.identityDomainsApprovalWorkflowAssignment.IdentityDomainsApprovalWorkflowAssignmentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "assignmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssignmentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
