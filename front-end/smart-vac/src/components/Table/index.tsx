import BootstrapTable, { BootstrapTableProps } from "react-bootstrap-table-next";
import paginationFactory from "react-bootstrap-table2-paginator";
import { TableContainer } from "./style";

const paginationOptions = {
    sizePerPage: 50,
    hideSizePerPage: true, 
    hidePageListOnlyOnePage: true,
    showTotal: true,
    paginationTotalRenderer: (from: number, to: number, size: number) => {
        return (
            <span className="react-bootstrap-table-pagination-total">
                Mostrando { from } até { to } de { size } resultados
            </span>
        );
    },
  };
  

export default function Table(props: BootstrapTableProps) {

    return (
        <TableContainer>
            <BootstrapTable
                {...props}
                keyField='vacina'
                striped
                pagination={paginationFactory(paginationOptions)}
            />
        </TableContainer>
    );
}
