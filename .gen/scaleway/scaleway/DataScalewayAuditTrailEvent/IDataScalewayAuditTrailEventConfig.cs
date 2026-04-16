using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayAuditTrailEvent
{
    [JsiiInterface(nativeType: typeof(IDataScalewayAuditTrailEventConfig), fullyQualifiedName: "scaleway.dataScalewayAuditTrailEvent.DataScalewayAuditTrailEventConfig")]
    public interface IDataScalewayAuditTrailEventConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#id DataScalewayAuditTrailEvent#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the method of the API call performed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#method_name DataScalewayAuditTrailEvent#method_name}
        /// </remarks>
        [JsiiProperty(name: "methodName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MethodName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the order in which events are returned. Default value: recorded_at_desc.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#order_by DataScalewayAuditTrailEvent#order_by}
        /// </remarks>
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrderBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the organization containing the Audit Trail events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#organization_id DataScalewayAuditTrailEvent#organization_id}
        /// </remarks>
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the User or IAM application at the origin of the event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#principal_id DataScalewayAuditTrailEvent#principal_id}
        /// </remarks>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrincipalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Scaleway product associated with the listed events in a hyphenated format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#product_name DataScalewayAuditTrailEvent#product_name}
        /// </remarks>
        [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProductName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the project containing the Audit Trail events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#project_id DataScalewayAuditTrailEvent#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The `recorded_after` parameter defines the earliest timestamp from which Audit Trail events are retrieved.</summary>
        /// <remarks>
        /// Returns <c>one hour ago</c> by default (Format ISO 8601)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#recorded_after DataScalewayAuditTrailEvent#recorded_after}
        /// </remarks>
        [JsiiProperty(name: "recordedAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecordedAfter
        {
            get
            {
                return null;
            }
        }

        /// <summary>The `recorded_before` parameter defines the latest timestamp up to which Audit Trail events are retrieved.</summary>
        /// <remarks>
        /// Must be later than recorded_after. Returns <c>now</c> by default (Format ISO 8601)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#recorded_before DataScalewayAuditTrailEvent#recorded_before}
        /// </remarks>
        [JsiiProperty(name: "recordedBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecordedBefore
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#region DataScalewayAuditTrailEvent#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the Scaleway resource associated with the listed events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#resource_id DataScalewayAuditTrailEvent#resource_id}
        /// </remarks>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of the scaleway resources associated with the listed events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#resource_type DataScalewayAuditTrailEvent#resource_type}
        /// </remarks>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the service of the API call performed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#service_name DataScalewayAuditTrailEvent#service_name}
        /// </remarks>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>IP address at the origin of the event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#source_ip DataScalewayAuditTrailEvent#source_ip}
        /// </remarks>
        [JsiiProperty(name: "sourceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>HTTP status code of the request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#status DataScalewayAuditTrailEvent#status}
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataScalewayAuditTrailEventConfig), fullyQualifiedName: "scaleway.dataScalewayAuditTrailEvent.DataScalewayAuditTrailEventConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.DataScalewayAuditTrailEvent.IDataScalewayAuditTrailEventConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#id DataScalewayAuditTrailEvent#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the method of the API call performed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#method_name DataScalewayAuditTrailEvent#method_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "methodName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MethodName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines the order in which events are returned. Default value: recorded_at_desc.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#order_by DataScalewayAuditTrailEvent#order_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the organization containing the Audit Trail events.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#organization_id DataScalewayAuditTrailEvent#organization_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the User or IAM application at the origin of the event.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#principal_id DataScalewayAuditTrailEvent#principal_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrincipalId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Scaleway product associated with the listed events in a hyphenated format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#product_name DataScalewayAuditTrailEvent#product_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProductName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the project containing the Audit Trail events.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#project_id DataScalewayAuditTrailEvent#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The `recorded_after` parameter defines the earliest timestamp from which Audit Trail events are retrieved.</summary>
            /// <remarks>
            /// Returns <c>one hour ago</c> by default (Format ISO 8601)
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#recorded_after DataScalewayAuditTrailEvent#recorded_after}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recordedAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecordedAfter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The `recorded_before` parameter defines the latest timestamp up to which Audit Trail events are retrieved.</summary>
            /// <remarks>
            /// Must be later than recorded_after. Returns <c>now</c> by default (Format ISO 8601)
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#recorded_before DataScalewayAuditTrailEvent#recorded_before}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recordedBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecordedBefore
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#region DataScalewayAuditTrailEvent#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the Scaleway resource associated with the listed events.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#resource_id DataScalewayAuditTrailEvent#resource_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Type of the scaleway resources associated with the listed events.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#resource_type DataScalewayAuditTrailEvent#resource_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the service of the API call performed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#service_name DataScalewayAuditTrailEvent#service_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>IP address at the origin of the event.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#source_ip DataScalewayAuditTrailEvent#source_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>HTTP status code of the request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/audit_trail_event#status DataScalewayAuditTrailEvent#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Status
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
