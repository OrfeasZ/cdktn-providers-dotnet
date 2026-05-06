using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AdmRemediationRecipe
{
    [JsiiInterface(nativeType: typeof(IAdmRemediationRecipeDetectConfiguration), fullyQualifiedName: "oci.admRemediationRecipe.AdmRemediationRecipeDetectConfiguration")]
    public interface IAdmRemediationRecipeDetectConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#exclusions AdmRemediationRecipe#exclusions}.</summary>
        [JsiiProperty(name: "exclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Exclusions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#max_permissible_cvss_v2score AdmRemediationRecipe#max_permissible_cvss_v2score}.</summary>
        [JsiiProperty(name: "maxPermissibleCvssV2Score", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPermissibleCvssV2Score
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#max_permissible_cvss_v3score AdmRemediationRecipe#max_permissible_cvss_v3score}.</summary>
        [JsiiProperty(name: "maxPermissibleCvssV3Score", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPermissibleCvssV3Score
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#max_permissible_severity AdmRemediationRecipe#max_permissible_severity}.</summary>
        [JsiiProperty(name: "maxPermissibleSeverity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxPermissibleSeverity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#upgrade_policy AdmRemediationRecipe#upgrade_policy}.</summary>
        [JsiiProperty(name: "upgradePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpgradePolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAdmRemediationRecipeDetectConfiguration), fullyQualifiedName: "oci.admRemediationRecipe.AdmRemediationRecipeDetectConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.AdmRemediationRecipe.IAdmRemediationRecipeDetectConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#exclusions AdmRemediationRecipe#exclusions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Exclusions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#max_permissible_cvss_v2score AdmRemediationRecipe#max_permissible_cvss_v2score}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPermissibleCvssV2Score", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPermissibleCvssV2Score
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#max_permissible_cvss_v3score AdmRemediationRecipe#max_permissible_cvss_v3score}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPermissibleCvssV3Score", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPermissibleCvssV3Score
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#max_permissible_severity AdmRemediationRecipe#max_permissible_severity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPermissibleSeverity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxPermissibleSeverity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#upgrade_policy AdmRemediationRecipe#upgrade_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upgradePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpgradePolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
