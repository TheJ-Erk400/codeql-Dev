// generated by codegen, do not edit
import codeql.rust.elements
import TestUtils

from PtrTypeRepr x, string isConst, string isMut, string hasTypeRepr
where
  toBeTested(x) and
  not x.isUnknown() and
  (if x.isConst() then isConst = "yes" else isConst = "no") and
  (if x.isMut() then isMut = "yes" else isMut = "no") and
  if x.hasTypeRepr() then hasTypeRepr = "yes" else hasTypeRepr = "no"
select x, "isConst:", isConst, "isMut:", isMut, "hasTypeRepr:", hasTypeRepr
