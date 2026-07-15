using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiInterface(nativeType: typeof(ISecurityhubAutomationRuleCriteria), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteria")]
    public interface ISecurityhubAutomationRuleCriteria
    {
        /// <summary>aws_account_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#aws_account_id SecurityhubAutomationRule#aws_account_id}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaAwsAccountId" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "awsAccountId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsAccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>aws_account_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#aws_account_name SecurityhubAutomationRule#aws_account_name}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaAwsAccountName" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "awsAccountName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsAccountName
        {
            get
            {
                return null;
            }
        }

        /// <summary>company_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#company_name SecurityhubAutomationRule#company_name}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCompanyName" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "companyName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCompanyName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CompanyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>compliance_associated_standards_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#compliance_associated_standards_id SecurityhubAutomationRule#compliance_associated_standards_id}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsId" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "complianceAssociatedStandardsId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ComplianceAssociatedStandardsId
        {
            get
            {
                return null;
            }
        }

        /// <summary>compliance_security_control_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#compliance_security_control_id SecurityhubAutomationRule#compliance_security_control_id}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceSecurityControlId" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "complianceSecurityControlId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceSecurityControlId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ComplianceSecurityControlId
        {
            get
            {
                return null;
            }
        }

        /// <summary>compliance_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#compliance_status SecurityhubAutomationRule#compliance_status}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceStatus" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "complianceStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ComplianceStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>confidence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#confidence SecurityhubAutomationRule#confidence}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaConfidence" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "confidence", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaConfidence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Confidence
        {
            get
            {
                return null;
            }
        }

        /// <summary>created_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#created_at SecurityhubAutomationRule#created_at}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCreatedAt" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "createdAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCreatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreatedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>criticality block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#criticality SecurityhubAutomationRule#criticality}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCriticality" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "criticality", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCriticality\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Criticality
        {
            get
            {
                return null;
            }
        }

        /// <summary>description block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#description SecurityhubAutomationRule#description}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaDescription" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaDescription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>first_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#first_observed_at SecurityhubAutomationRule#first_observed_at}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaFirstObservedAt" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "firstObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaFirstObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FirstObservedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>generator_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#generator_id SecurityhubAutomationRule#generator_id}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaGeneratorId" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "generatorId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaGeneratorId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GeneratorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#id SecurityhubAutomationRule#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaId" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>last_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#last_observed_at SecurityhubAutomationRule#last_observed_at}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaLastObservedAt" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "lastObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LastObservedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>note_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#note_text SecurityhubAutomationRule#note_text}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteText" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "noteText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoteText
        {
            get
            {
                return null;
            }
        }

        /// <summary>note_updated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#note_updated_at SecurityhubAutomationRule#note_updated_at}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteUpdatedAt" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "noteUpdatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoteUpdatedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>note_updated_by block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#note_updated_by SecurityhubAutomationRule#note_updated_by}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteUpdatedBy" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "noteUpdatedBy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedBy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoteUpdatedBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>product_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#product_arn SecurityhubAutomationRule#product_arn}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaProductArn" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "productArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProductArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>product_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#product_name SecurityhubAutomationRule#product_name}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaProductName" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "productName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProductName
        {
            get
            {
                return null;
            }
        }

        /// <summary>record_state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#record_state SecurityhubAutomationRule#record_state}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRecordState" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "recordState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRecordState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecordState
        {
            get
            {
                return null;
            }
        }

        /// <summary>related_findings_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#related_findings_id SecurityhubAutomationRule#related_findings_id}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRelatedFindingsId" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "relatedFindingsId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RelatedFindingsId
        {
            get
            {
                return null;
            }
        }

        /// <summary>related_findings_product_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#related_findings_product_arn SecurityhubAutomationRule#related_findings_product_arn}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRelatedFindingsProductArn" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "relatedFindingsProductArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RelatedFindingsProductArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_application_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_application_arn SecurityhubAutomationRule#resource_application_arn}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceApplicationArn" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceApplicationArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceApplicationArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_application_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_application_name SecurityhubAutomationRule#resource_application_name}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceApplicationName" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceApplicationName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceApplicationName
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_details_other block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_details_other SecurityhubAutomationRule#resource_details_other}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceDetailsOther" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceDetailsOther", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceDetailsOther\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceDetailsOther
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_id SecurityhubAutomationRule#resource_id}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceId" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_partition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_partition SecurityhubAutomationRule#resource_partition}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourcePartition" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourcePartition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourcePartition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourcePartition
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_region SecurityhubAutomationRule#resource_region}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceRegion" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceRegion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_tags SecurityhubAutomationRule#resource_tags}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceTags" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_type SecurityhubAutomationRule#resource_type}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceType" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>severity_label block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#severity_label SecurityhubAutomationRule#severity_label}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaSeverityLabel" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "severityLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaSeverityLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SeverityLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#source_url SecurityhubAutomationRule#source_url}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaSourceUrl" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sourceUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>title block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#title SecurityhubAutomationRule#title}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaTitle" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "title", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaTitle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Title
        {
            get
            {
                return null;
            }
        }

        /// <summary>type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#type SecurityhubAutomationRule#type}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaType" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>updated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#updated_at SecurityhubAutomationRule#updated_at}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaUpdatedAt" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "updatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UpdatedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_defined_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#user_defined_fields SecurityhubAutomationRule#user_defined_fields}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaUserDefinedFields" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "userDefinedFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaUserDefinedFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserDefinedFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>verification_state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#verification_state SecurityhubAutomationRule#verification_state}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaVerificationState" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "verificationState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaVerificationState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VerificationState
        {
            get
            {
                return null;
            }
        }

        /// <summary>workflow_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#workflow_status SecurityhubAutomationRule#workflow_status}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaWorkflowStatus" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "workflowStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaWorkflowStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WorkflowStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubAutomationRuleCriteria), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_account_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#aws_account_id SecurityhubAutomationRule#aws_account_id}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaAwsAccountId" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsAccountId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsAccountId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>aws_account_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#aws_account_name SecurityhubAutomationRule#aws_account_name}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaAwsAccountName" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsAccountName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsAccountName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>company_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#company_name SecurityhubAutomationRule#company_name}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCompanyName" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "companyName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCompanyName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CompanyName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>compliance_associated_standards_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#compliance_associated_standards_id SecurityhubAutomationRule#compliance_associated_standards_id}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsId" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "complianceAssociatedStandardsId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ComplianceAssociatedStandardsId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>compliance_security_control_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#compliance_security_control_id SecurityhubAutomationRule#compliance_security_control_id}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceSecurityControlId" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "complianceSecurityControlId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceSecurityControlId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ComplianceSecurityControlId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>compliance_status block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#compliance_status SecurityhubAutomationRule#compliance_status}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceStatus" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "complianceStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ComplianceStatus
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>confidence block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#confidence SecurityhubAutomationRule#confidence}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaConfidence" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "confidence", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaConfidence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Confidence
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>created_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#created_at SecurityhubAutomationRule#created_at}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCreatedAt" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCreatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CreatedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>criticality block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#criticality SecurityhubAutomationRule#criticality}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCriticality" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "criticality", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCriticality\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Criticality
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>description block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#description SecurityhubAutomationRule#description}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaDescription" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaDescription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Description
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>first_observed_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#first_observed_at SecurityhubAutomationRule#first_observed_at}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaFirstObservedAt" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firstObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaFirstObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FirstObservedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>generator_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#generator_id SecurityhubAutomationRule#generator_id}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaGeneratorId" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "generatorId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaGeneratorId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GeneratorId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#id SecurityhubAutomationRule#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaId" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Id
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>last_observed_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#last_observed_at SecurityhubAutomationRule#last_observed_at}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaLastObservedAt" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lastObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LastObservedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>note_text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#note_text SecurityhubAutomationRule#note_text}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteText" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "noteText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NoteText
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>note_updated_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#note_updated_at SecurityhubAutomationRule#note_updated_at}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteUpdatedAt" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "noteUpdatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NoteUpdatedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>note_updated_by block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#note_updated_by SecurityhubAutomationRule#note_updated_by}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteUpdatedBy" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "noteUpdatedBy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedBy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NoteUpdatedBy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>product_arn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#product_arn SecurityhubAutomationRule#product_arn}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaProductArn" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "productArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProductArn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>product_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#product_name SecurityhubAutomationRule#product_name}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaProductName" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "productName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProductName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>record_state block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#record_state SecurityhubAutomationRule#record_state}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRecordState" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recordState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRecordState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecordState
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>related_findings_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#related_findings_id SecurityhubAutomationRule#related_findings_id}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRelatedFindingsId" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relatedFindingsId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RelatedFindingsId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>related_findings_product_arn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#related_findings_product_arn SecurityhubAutomationRule#related_findings_product_arn}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRelatedFindingsProductArn" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relatedFindingsProductArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RelatedFindingsProductArn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_application_arn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_application_arn SecurityhubAutomationRule#resource_application_arn}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceApplicationArn" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceApplicationArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceApplicationArn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_application_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_application_name SecurityhubAutomationRule#resource_application_name}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceApplicationName" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceApplicationName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceApplicationName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_details_other block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_details_other SecurityhubAutomationRule#resource_details_other}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceDetailsOther" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceDetailsOther", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceDetailsOther\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceDetailsOther
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_id SecurityhubAutomationRule#resource_id}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceId" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_partition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_partition SecurityhubAutomationRule#resource_partition}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourcePartition" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourcePartition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourcePartition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourcePartition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_region block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_region SecurityhubAutomationRule#resource_region}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceRegion" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceRegion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceRegion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_tags SecurityhubAutomationRule#resource_tags}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceTags" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#resource_type SecurityhubAutomationRule#resource_type}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceType" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceType
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>severity_label block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#severity_label SecurityhubAutomationRule#severity_label}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaSeverityLabel" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "severityLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaSeverityLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SeverityLabel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>source_url block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#source_url SecurityhubAutomationRule#source_url}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaSourceUrl" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceUrl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>title block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#title SecurityhubAutomationRule#title}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaTitle" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "title", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaTitle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Title
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#type SecurityhubAutomationRule#type}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaType" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Type
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>updated_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#updated_at SecurityhubAutomationRule#updated_at}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaUpdatedAt" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "updatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UpdatedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>user_defined_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#user_defined_fields SecurityhubAutomationRule#user_defined_fields}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaUserDefinedFields" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userDefinedFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaUserDefinedFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UserDefinedFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>verification_state block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#verification_state SecurityhubAutomationRule#verification_state}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaVerificationState" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verificationState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaVerificationState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VerificationState
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>workflow_status block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/securityhub_automation_rule#workflow_status SecurityhubAutomationRule#workflow_status}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaWorkflowStatus" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workflowStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaWorkflowStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WorkflowStatus
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
